﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.ProspestiveRisks.Dto
{
    public class ProspectiveRiskHistoryGetDto : EntityDto
    {
        public ProspectiveRiskUserDto CreationUser { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime EvaluatedTime { get; set; }
        public decimal Weight { get; set; }
        public decimal FixValue { get; set; }
        public decimal Value { get; set; }
        public List<ProspectiveRiskHistoryVariableGetDto> Variables { get; set; }
    }
}
