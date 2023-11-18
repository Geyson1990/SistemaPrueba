﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.DirectoryIndustries.Dto
{
    public class DirectoryIndustryProvinceDto : EntityDto
    {
        public string Name { get; set; }
        public List<DirectoryIndustryDistrictDto> Districts { get; set; }
    }
}