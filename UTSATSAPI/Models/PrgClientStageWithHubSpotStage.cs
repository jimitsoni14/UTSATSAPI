﻿using System;
using System.Collections.Generic;

namespace TalentConnectAdminAPI.Models
{
    public partial class PrgClientStageWithHubSpotStage
    {
        public int Id { get; set; }
        public string ClientStageName { get; set; } = null!;
        public int? Sequence { get; set; }
        public string? ActionId { get; set; }
    }
}
