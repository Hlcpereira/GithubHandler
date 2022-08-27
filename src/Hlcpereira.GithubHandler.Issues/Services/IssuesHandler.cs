/**
 * Copyright 2022 - Henrique Pereira/Hlcpereira
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System.Collections.Generic;
using System.Threading.Tasks;

using Hlcpereira.GithubHandler.CrossCutting.Constants;
using Hlcpereira.GithubHandler.CrossCutting.Utils.Contracts;
using Hlcpereira.GithubHandler.Issues.Projections;
using Hlcpereira.GithubHandler.Issues.ViewModels;

namespace Hlcpereira.GithubHandler.Issues.Services
{
    public class IssuesHandler
    {
        private string _owner;

        private string _repo;

        private IHttpClient _httpClient;

        public IssuesHandler(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IssueVm> FindIssueByFilter()
        {
            var issue = new IssueVm();

            return issue
        }

        public async Task<IList<IssueVm>> GetIssuesByFilter()
        {
            
        }

        public async Task<IList<IssueCountdownVm>> CountIssuesByFilter()
        {
            
        }

        public async Task<string> ExecuteApiRequest()
        {
            var response = await _httpClient.Send<string>();

            return response;
        }
    }    
}
