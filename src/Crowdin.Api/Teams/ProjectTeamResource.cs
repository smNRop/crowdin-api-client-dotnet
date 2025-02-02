﻿
using System.Collections.Generic;
using Crowdin.Api.Users;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Crowdin.Api.Teams
{
    [PublicAPI]
    public class ProjectTeamResource
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("hasManagerAccess")]
        public bool HasManagerAccess { get; set; }
        
        [JsonProperty("hasAccessToAllWorkflowSteps")]
        public bool HasAccessToAllWorkflowSteps { get; set; }
        
        [JsonProperty("permissions")]
#pragma warning disable CS8618
        public IDictionary<string, LanguagePermission> Permissions { get; set; }
#pragma warning restore CS8618
    }
}