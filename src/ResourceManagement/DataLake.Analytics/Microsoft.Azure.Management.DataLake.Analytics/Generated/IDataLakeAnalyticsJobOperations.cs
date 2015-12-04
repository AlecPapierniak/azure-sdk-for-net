// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// DataLakeAnalyticsJobOperations operations.
    /// </summary>
    public partial interface IDataLakeAnalyticsJobOperations
    {
        /// <summary>
        /// Gets the job statistics object specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobStatistics>> GetStatisticsWithHttpMessagesAsync(string accountName, string jobIdentity, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the U-SQL job debug data information specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobDataPath>> GetDebugDataPathWithHttpMessagesAsync(string accountName, string jobIdentity, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Builds (compiles) the specified job in the specified Data Lake
        /// Analytics account for job correctness and validation.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to build the job for
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to build a job, which simulates submission.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobInformation>> BuildWithHttpMessagesAsync(string accountName, string resourceGroupName, JobInfoBuildOrCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Submits the specified job to the specified Data Lake Analytics
        /// account for computation.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to create the job for
        /// </param>
        /// <param name='jobId'>
        /// The parameters to submit a job.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to submit a job.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobInformation>> CreateWithHttpMessagesAsync(string accountName, string jobId, string resourceGroupName, JobInfoBuildOrCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the running job specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to cancel the job for
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID to cancel.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string accountName, string jobIdentity, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the JobInfo object specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='jobIdentity'>
        /// JobInfo ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobInformation>> GetWithHttpMessagesAsync(string accountName, string jobIdentity, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics JobInformation
        /// objects within the specified resource group with a link to the
        /// next page, if any.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to get the job from
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='odataQuery'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='select'>
        /// Query parameters. If null is passed returns all JobInfo items.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<JobInformation>>> ListWithHttpMessagesAsync(string accountName, string resourceGroupName, ODataQuery<JobInformation> odataQuery = default(ODataQuery<JobInformation>), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics JobInformation
        /// objects within the specified resource group with a link to the
        /// next page, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<JobInformation>>> ListNextWithHttpMessagesAsync(string nextPageLink, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
