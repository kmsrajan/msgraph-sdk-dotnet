// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Team.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Team : Entity
    {
    
        /// <summary>
        /// Gets or sets member settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamMemberSettings MemberSettings { get; set; }
    
        /// <summary>
        /// Gets or sets messaging settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messagingSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamMessagingSettings MessagingSettings { get; set; }
    
        /// <summary>
        /// Gets or sets fun settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamFunSettings FunSettings { get; set; }
    
        /// <summary>
        /// Gets or sets guest settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "guestSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamGuestSettings GuestSettings { get; set; }
    
        /// <summary>
        /// Gets or sets channels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "channels", Required = Newtonsoft.Json.Required.Default)]
        public ITeamChannelsCollectionPage Channels { get; set; }
    
    }
}
