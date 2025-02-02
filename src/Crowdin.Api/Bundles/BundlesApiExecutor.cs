﻿
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using JetBrains.Annotations;

using Crowdin.Api.Core;
using Crowdin.Api.SourceFiles;

namespace Crowdin.Api.Bundles
{
    public class BundlesApiExecutor
    {
        private readonly ICrowdinApiClient _apiClient;
        private readonly IJsonParser _jsonParser;
        
        public BundlesApiExecutor(ICrowdinApiClient apiClient)
        {
            _apiClient = apiClient;
            _jsonParser = apiClient.DefaultJsonParser;
        }
        
        public BundlesApiExecutor(ICrowdinApiClient apiClient, IJsonParser jsonParser)
        {
            _apiClient = apiClient;
            _jsonParser = jsonParser;
        }
        
        /// <summary>
        /// List bundles. Documentation:
        /// <a href="https://developer.crowdin.com/api/v2/#operation/api.projects.bundles.getMany">Crowdin API</a>
        /// <a href="https://developer.crowdin.com/enterprise/api/v2/#operation/api.projects.bundles.getMany">Crowdin Enterprise API</a>
        /// </summary>
        [PublicAPI]
        public async Task<ResponseList<Bundle>> ListBundles(int projectId, int limit = 25, int offset = 0)
        {
            string url = FormUrl_Bundles(projectId);
            
            IDictionary<string, string> queryParams = Utils.CreateQueryParamsFromPaging(limit, offset);
            
            CrowdinApiResult result = await _apiClient.SendGetRequest(url, queryParams);
            return _jsonParser.ParseResponseList<Bundle>(result.JsonObject);
        }
        
        /// <summary>
        /// Add bundle. Documentation:
        /// <a href="https://developer.crowdin.com/api/v2/#operation/api.projects.bundles.post">Crowdin API</a>
        /// <a href="https://developer.crowdin.com/enterprise/api/v2/#operation/api.projects.bundles.post">Crowdin Enterprise API</a>
        /// </summary>
        [PublicAPI]
        public async Task<Bundle> AddBundle(int projectId, AddBundleRequest request)
        {
            string url = FormUrl_Bundles(projectId);
            CrowdinApiResult result = await _apiClient.SendPostRequest(url, request);
            return _jsonParser.ParseResponseObject<Bundle>(result.JsonObject);
        }
        
        /// <summary>
        /// Get bundle. Documentation:
        /// <a href="https://developer.crowdin.com/api/v2/#operation/api.projects.bundles.get">Crowdin API</a>
        /// <a href="https://developer.crowdin.com/enterprise/api/v2/#operation/api.projects.bundles.get">Crowdin Enterprise API</a>
        /// </summary>
        [PublicAPI]
        public async Task<Bundle> GetBundle(int projectId, int bundleId)
        {
            string url = FormUrl_BundleId(projectId, bundleId);
            CrowdinApiResult result = await _apiClient.SendGetRequest(url);
            return _jsonParser.ParseResponseObject<Bundle>(result.JsonObject);
        }
        
        /// <summary>
        /// Delete bundle. Documentation:
        /// <a href="https://developer.crowdin.com/api/v2/#operation/api.projects.bundles.delete">Crowdin API</a>
        /// <a href="https://developer.crowdin.com/enterprise/api/v2/#operation/api.projects.bundles.delete">Crowdin Enterprise API</a>
        /// </summary>
        [PublicAPI]
        public async Task DeleteBundle(int projectId, int bundleId)
        {
            string url = FormUrl_BundleId(projectId, bundleId);
            HttpStatusCode statusCode = await _apiClient.SendDeleteRequest(url);
            Utils.ThrowIfStatusNot204(statusCode, $"Bundle {bundleId} removal failed");
        }
        
        /// <summary>
        /// Edit bundle. Documentation:
        /// <a href="https://developer.crowdin.com/api/v2/#operation/api.projects.bundles.patch">Crowdin API</a>
        /// <a href="https://developer.crowdin.com/enterprise/api/v2/#operation/api.projects.bundles.patch">Crowdin Enterprise API</a>
        /// </summary>
        [PublicAPI]
        public async Task<Bundle> EditBundle(int projectId, int bundleId, IEnumerable<BundlePatch> patches)
        {
            string url = FormUrl_BundleId(projectId, bundleId);
            CrowdinApiResult result = await _apiClient.SendPatchRequest(url, patches);
            return _jsonParser.ParseResponseObject<Bundle>(result.JsonObject);
        }
        
        /// <summary>
        /// Bundle list files. Documentation:
        /// <a href="https://developer.crowdin.com/api/v2/#operation/api.projects.bundles.files.getMany">Crowdin API</a>
        /// <a href="https://developer.crowdin.com/enterprise/api/v2/#operation/api.projects.bundles.files.getMany">Crowdin Enterprise API</a>
        /// </summary>
        [PublicAPI]
        public async Task<ResponseList<T>> BundleListFiles<T>(
            int projectId, int bundleId, int limit = 25, int offset = 0)
            where T : FileResourceBase
        {
            string url = FormUrl_BundleFiles(projectId, bundleId);
            IDictionary<string, string> queryParams = Utils.CreateQueryParamsFromPaging(limit, offset);
            
            CrowdinApiResult result = await _apiClient.SendGetRequest(url, queryParams);
            return _jsonParser.ParseResponseList<T>(result.JsonObject);
        }
        
        #region Helper methods
        
        private static string FormUrl_Bundles(int projectId)
        {
            return $"/projects/{projectId}/bundles";
        }
        
        private static string FormUrl_BundleId(int projectId, int bundleId)
        {
            return $"/projects/{projectId}/bundles/{bundleId}";
        }
        
        private static string FormUrl_BundleFiles(int projectId, int bundleId)
        {
            return $"/projects/{projectId}/bundles/{bundleId}/files";
        }
        
        #endregion
    }
}