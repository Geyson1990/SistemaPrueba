﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.InterventionPlanRoles.Dto
{
    public class InterventionPlanRoleGetAllDto : EntityDto
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool ShowDescription { get; set; }
    }
}
