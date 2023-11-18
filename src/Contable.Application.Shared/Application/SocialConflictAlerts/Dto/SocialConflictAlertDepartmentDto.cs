﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.SocialConflictAlerts.Dto
{
    public class SocialConflictAlertDepartmentDto : EntityDto
    {
        public int TerritorialUnitId { get;set; }
        public string Name { get;set; }
        public List<SocialConflictAlertProvinceDto> Provinces { get; set; }
    }
}
