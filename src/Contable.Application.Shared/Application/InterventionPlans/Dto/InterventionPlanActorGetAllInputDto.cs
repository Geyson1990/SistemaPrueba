﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.InterventionPlans.Dto
{
    public class InterventionPlanActorGetAllInputDto 
    {
        public int ConflictId { get; set; }
        public ConflictSite Site { get; set; }
    }
}
