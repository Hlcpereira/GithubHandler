/**
 * Copyright 2022 - Henrique Pereira/Hlcpereira
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System.Threading.Tasks;

using RestSharp;

using Hlcpereira.GithubHandler.CrossCutting.Utils.Contracts;

namespace Hlcpereira.GithubHandler.CrossCutting.Utils.HttpClient
{
    public class HttpClient : IHttpClient
    {
        public Task Send()
        {

        }

        public Task<T> Send<T>()
        {
            return response;
        }
    }
}
