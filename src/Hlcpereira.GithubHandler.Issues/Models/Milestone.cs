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
    public class Milestone
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("labels_url")]
        public Uri LabelsUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("creator")]
        public Assignee Creator { get; set; }

        [JsonProperty("open_issues")]
        public long OpenIssues { get; set; }

        [JsonProperty("closed_issues")]
        public long ClosedIssues { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public DateTimeOffset ClosedAt { get; set; }

        [JsonProperty("due_on")]
        public DateTimeOffset DueOn { get; set; }
    }
}
