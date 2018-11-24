/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

using Amazon;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal;
using Amazon.Util;
using System.Threading;
using Amazon.Util.Internal;

namespace Amazon
{
    /// <summary>
    /// A singleton instance of which will initialize the Main thread dispatcher & logger.
    /// This class is linked to the AWSPrefab so that user can make any configuration 
    /// changes and instance will be included in every scene via the prefab.
    /// </summary>
    public class UnityInitializer : MonoBehaviour
    {
        #region public api
        /// <summary>
        /// Make sure this is called before any other AWSSDK code is run
        /// If using this SDK in Editor mode, call EditorApplication.LockReloadAssemblies before calling this
        /// Keep managerGO from being destroyed during the AWS Session, it maintains a main thread dispatcher running a coroutine
        /// If in Editor mode, set UnityMainThreadDispatcher returned to run in edit mode
        /// </summary>
        public static UnityMainThreadDispatcher StartAWSSession(GameObject managerGO)
        {
            if (_mainThread == null || !_mainThread.Equals(Thread.CurrentThread))
                _mainThread = Thread.CurrentThread;

            AWSConfigs.HttpClient = AWSConfigs.HttpClientOption.UnityWebRequest;

            AmazonHookedPlatformInfo.Instance.Init();

            TraceListener tracelistener = new UnityDebugTraceListener("UnityDebug");
            AWSConfigs.AddTraceListener("Amazon", tracelistener);

            return managerGO.AddComponent<UnityMainThreadDispatcher>();
        }

        /// <summary>
        /// Make sure this is called after all call to AWSSDK service gracefully finishes
        /// If using this SDK in Editor mode, call EditorApplication.UnlockReloadAssemblies after calling this
        /// </summary>
        public static void EndAWSSession(UnityMainThreadDispatcher dispatcher)
        {
            Destroy(dispatcher);

            AWSConfigs.RemoveTraceListener("Amazon", "UnityDebug");
        }
        #endregion

        private static Thread _mainThread;
        /// <summary>
        /// Checks if the thread is a game/main/unity thread
        /// </summary>
        /// <returns>true if the thread is the game/main/unity thread, else false</returns>
        public static bool IsMainThread()
        {
            if (null == _mainThread)
            {
                throw new Exception("Main thread has not been set, is the AWSPrefab on the scene?");
            }
            return Thread.CurrentThread.Equals(_mainThread);
        }

    }
}
