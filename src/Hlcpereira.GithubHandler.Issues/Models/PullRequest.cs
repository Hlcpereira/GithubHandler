/**
 * Copyright 2022 - Henrique Pereira/Hlcpereira
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;
using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hlcpereira.GithubHandler.Issues.Models
{
    public class PullRequest
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("diff_url")]
        public Uri DiffUrl { get; set; }

        [JsonProperty("patch_url")]
        public Uri PatchUrl { get; set; }
    }
}
