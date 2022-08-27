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
    public class Label
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }
    }
}
