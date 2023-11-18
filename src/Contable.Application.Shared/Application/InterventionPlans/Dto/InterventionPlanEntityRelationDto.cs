﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.InterventionPlans.Dto
{
    public class InterventionPlanEntityRelationDto : EntityDto
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public InterventionPlanEntityType Type { get; set; }
    }
}
