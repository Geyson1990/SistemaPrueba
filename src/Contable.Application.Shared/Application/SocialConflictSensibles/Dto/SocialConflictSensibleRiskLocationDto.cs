﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.SocialConflictSensibles.Dto
{
    public class SocialConflictSensibleRiskLocationDto : EntityDto
    {
        public SocialConflictSensibleRiskDto Risk { get; set; }
        public DateTime RiskTime { get; set; }
        public string Description { get; set; }
        public string VerificationState { get; set; }
        public bool VerificationChange { get; set; }
        public bool VerificationLocation { get; set; }
        public bool Remove { get; set; }
    }
}
