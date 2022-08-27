/**
 * Copyright 2022 - Henrique Pereira/Hlcpereira
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System.Threading.Tasks;

using RestSharp;

namespace Hlcpereira.GithubHandler.CrossCutting.Utils.Contracts
{
    public interface IHttpClient
    {
        public Task Send();

        public Task<T> Send<T>();
    }
}
