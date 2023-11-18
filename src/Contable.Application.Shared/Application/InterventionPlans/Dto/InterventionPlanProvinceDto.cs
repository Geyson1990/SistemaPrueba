﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.InterventionPlans.Dto
{
    public class InterventionPlanProvinceDto : EntityDto
    {
        public string Name { get; set; }
        public List<InterventionPlanDistrictDto> Districts { get; set; }
    }
}
