﻿using System;
using System.Collections.Generic;

namespace TalentConnectAdminAPI.Models
{
    public partial class PrgSkillsInAssesment
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? SkillId { get; set; }
        public bool? IsPrimary { get; set; }
    }
}