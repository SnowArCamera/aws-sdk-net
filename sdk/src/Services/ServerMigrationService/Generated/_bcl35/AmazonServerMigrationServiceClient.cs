/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ServerMigrationService.Model;
using Amazon.ServerMigrationService.Model.Internal.MarshallTransformations;
using Amazon.ServerMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServerMigrationService
{
    /// <summary>
    /// Implementation for accessing ServerMigrationService
    ///
    /// Amazon Server Migration Service automates the process of migrating servers to EC2.
    /// </summary>
    public partial class AmazonServerMigrationServiceClient : AmazonServiceClient, IAmazonServerMigrationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonServerMigrationServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonServerMigrationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerMigrationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerMigrationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(AmazonServerMigrationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServerMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials and an
        /// AmazonServerMigrationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials, AmazonServerMigrationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerMigrationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServerMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServerMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateReplicationJob

        /// <summary>
        /// The CreateReplicationJob API is used to create a ReplicationJob to replicate a server
        /// on AWS. Call this API to first create a ReplicationJob, which will then schedule periodic
        /// ReplicationRuns to replicate your server to AWS. Each ReplicationRun will result in
        /// the creation of an AWS AMI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error has occured.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// No connectors are available to handle this request. Please associate connector(s)
        /// and verify any existing connectors are healthy and can respond to requests.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobAlreadyExistsException">
        /// An active Replication Job already exists for the specified server.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The provided server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual CreateReplicationJobResponse CreateReplicationJob(CreateReplicationJobRequest request)
        {
            var marshaller = CreateReplicationJobRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationJobRequest,CreateReplicationJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationJob(CreateReplicationJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateReplicationJobRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return BeginInvoke<CreateReplicationJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationJob.</param>
        /// 
        /// <returns>Returns a  CreateReplicationJobResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual CreateReplicationJobResponse EndCreateReplicationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationJob

        /// <summary>
        /// The DeleteReplicationJob API is used to delete a ReplicationJob, resulting in no further
        /// ReplicationRuns. This will delete the contents of the S3 bucket used to store SMS
        /// artifacts, but will not delete any AMIs created by the SMS service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified Replication Job cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual DeleteReplicationJobResponse DeleteReplicationJob(DeleteReplicationJobRequest request)
        {
            var marshaller = DeleteReplicationJobRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationJobRequest,DeleteReplicationJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationJob(DeleteReplicationJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteReplicationJobRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteReplicationJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationJob.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationJobResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual DeleteReplicationJobResponse EndDeleteReplicationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServerCatalog

        /// <summary>
        /// The DeleteServerCatalog API clears all servers from your server catalog. This means
        /// that these servers will no longer be accessible to the Server Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual DeleteServerCatalogResponse DeleteServerCatalog(DeleteServerCatalogRequest request)
        {
            var marshaller = DeleteServerCatalogRequestMarshaller.Instance;
            var unmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCatalogRequest,DeleteServerCatalogResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServerCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual IAsyncResult BeginDeleteServerCatalog(DeleteServerCatalogRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteServerCatalogRequestMarshaller.Instance;
            var unmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteServerCatalogRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCatalog.</param>
        /// 
        /// <returns>Returns a  DeleteServerCatalogResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual DeleteServerCatalogResponse EndDeleteServerCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServerCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateConnector

        /// <summary>
        /// The DisassociateConnector API will disassociate a connector from the Server Migration
        /// Service, rendering it unavailable to support replication jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnector service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual DisassociateConnectorResponse DisassociateConnector(DisassociateConnectorRequest request)
        {
            var marshaller = DisassociateConnectorRequestMarshaller.Instance;
            var unmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectorRequest,DisassociateConnectorResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual IAsyncResult BeginDisassociateConnector(DisassociateConnectorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateConnectorRequestMarshaller.Instance;
            var unmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateConnectorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnector.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectorResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual DisassociateConnectorResponse EndDisassociateConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectors

        /// <summary>
        /// The GetConnectors API returns a list of connectors that are registered with the Server
        /// Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors service method.</param>
        /// 
        /// <returns>The response from the GetConnectors service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual GetConnectorsResponse GetConnectors(GetConnectorsRequest request)
        {
            var marshaller = GetConnectorsRequestMarshaller.Instance;
            var unmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return Invoke<GetConnectorsRequest,GetConnectorsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual IAsyncResult BeginGetConnectors(GetConnectorsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetConnectorsRequestMarshaller.Instance;
            var unmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke<GetConnectorsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectors.</param>
        /// 
        /// <returns>Returns a  GetConnectorsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual GetConnectorsResponse EndGetConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReplicationJobs

        /// <summary>
        /// The GetReplicationJobs API will return all of your ReplicationJobs and their details.
        /// This API returns a paginated list, that may be consecutively called with nextToken
        /// to retrieve all ReplicationJobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs service method.</param>
        /// 
        /// <returns>The response from the GetReplicationJobs service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual GetReplicationJobsResponse GetReplicationJobs(GetReplicationJobsRequest request)
        {
            var marshaller = GetReplicationJobsRequestMarshaller.Instance;
            var unmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return Invoke<GetReplicationJobsRequest,GetReplicationJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual IAsyncResult BeginGetReplicationJobs(GetReplicationJobsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetReplicationJobsRequestMarshaller.Instance;
            var unmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return BeginInvoke<GetReplicationJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationJobs.</param>
        /// 
        /// <returns>Returns a  GetReplicationJobsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual GetReplicationJobsResponse EndGetReplicationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReplicationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReplicationRuns

        /// <summary>
        /// The GetReplicationRuns API will return all ReplicationRuns for a given ReplicationJob.
        /// This API returns a paginated list, that may be consecutively called with nextToken
        /// to retrieve all ReplicationRuns for a ReplicationJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns service method.</param>
        /// 
        /// <returns>The response from the GetReplicationRuns service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual GetReplicationRunsResponse GetReplicationRuns(GetReplicationRunsRequest request)
        {
            var marshaller = GetReplicationRunsRequestMarshaller.Instance;
            var unmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return Invoke<GetReplicationRunsRequest,GetReplicationRunsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual IAsyncResult BeginGetReplicationRuns(GetReplicationRunsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetReplicationRunsRequestMarshaller.Instance;
            var unmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return BeginInvoke<GetReplicationRunsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationRuns.</param>
        /// 
        /// <returns>Returns a  GetReplicationRunsResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual GetReplicationRunsResponse EndGetReplicationRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReplicationRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServers

        /// <summary>
        /// The GetServers API returns a list of all servers in your server catalog. For this
        /// call to succeed, you must previously have called ImportServerCatalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServers service method.</param>
        /// 
        /// <returns>The response from the GetServers service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual GetServersResponse GetServers(GetServersRequest request)
        {
            var marshaller = GetServersRequestMarshaller.Instance;
            var unmarshaller = GetServersResponseUnmarshaller.Instance;

            return Invoke<GetServersRequest,GetServersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServers operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual IAsyncResult BeginGetServers(GetServersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetServersRequestMarshaller.Instance;
            var unmarshaller = GetServersResponseUnmarshaller.Instance;

            return BeginInvoke<GetServersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServers.</param>
        /// 
        /// <returns>Returns a  GetServersResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual GetServersResponse EndGetServers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportServerCatalog

        /// <summary>
        /// The ImportServerCatalog API is used to gather the complete list of on-premises servers
        /// on your premises. This API call requires connectors to be installed and monitoring
        /// all servers you would like imported. This API call returns immediately, but may take
        /// some time to retrieve all of the servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// No connectors are available to handle this request. Please associate connector(s)
        /// and verify any existing connectors are healthy and can respond to requests.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual ImportServerCatalogResponse ImportServerCatalog(ImportServerCatalogRequest request)
        {
            var marshaller = ImportServerCatalogRequestMarshaller.Instance;
            var unmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return Invoke<ImportServerCatalogRequest,ImportServerCatalogResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportServerCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual IAsyncResult BeginImportServerCatalog(ImportServerCatalogRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportServerCatalogRequestMarshaller.Instance;
            var unmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return BeginInvoke<ImportServerCatalogRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportServerCatalog.</param>
        /// 
        /// <returns>Returns a  ImportServerCatalogResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual ImportServerCatalogResponse EndImportServerCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportServerCatalogResponse>(asyncResult);
        }

        #endregion
        
        #region  StartOnDemandReplicationRun

        /// <summary>
        /// The StartOnDemandReplicationRun API is used to start a ReplicationRun on demand (in
        /// addition to those that are scheduled based on your frequency). This ReplicationRun
        /// will start immediately. StartOnDemandReplicationRun is subject to limits on how many
        /// on demand ReplicationRuns you may call per 24-hour period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandReplicationRun service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationRunLimitExceededException">
        /// This user has exceeded the maximum allowed Replication Run limit.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual StartOnDemandReplicationRunResponse StartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request)
        {
            var marshaller = StartOnDemandReplicationRunRequestMarshaller.Instance;
            var unmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return Invoke<StartOnDemandReplicationRunRequest,StartOnDemandReplicationRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOnDemandReplicationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual IAsyncResult BeginStartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartOnDemandReplicationRunRequestMarshaller.Instance;
            var unmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return BeginInvoke<StartOnDemandReplicationRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOnDemandReplicationRun.</param>
        /// 
        /// <returns>Returns a  StartOnDemandReplicationRunResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual StartOnDemandReplicationRunResponse EndStartOnDemandReplicationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartOnDemandReplicationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationJob

        /// <summary>
        /// The UpdateReplicationJob API is used to change the settings of your existing ReplicationJob
        /// created using CreateReplicationJob. Calling this API will affect the next scheduled
        /// ReplicationRun.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error has occured.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified Replication Job cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The provided server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual UpdateReplicationJobResponse UpdateReplicationJob(UpdateReplicationJobRequest request)
        {
            var marshaller = UpdateReplicationJobRequestMarshaller.Instance;
            var unmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationJobRequest,UpdateReplicationJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationJob(UpdateReplicationJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateReplicationJobRequestMarshaller.Instance;
            var unmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateReplicationJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationJob.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationJobResult from ServerMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual UpdateReplicationJobResponse EndUpdateReplicationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationJobResponse>(asyncResult);
        }

        #endregion
        
    }
}