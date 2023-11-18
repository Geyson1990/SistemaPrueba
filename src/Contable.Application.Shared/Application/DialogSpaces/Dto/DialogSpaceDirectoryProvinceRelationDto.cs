﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.DialogSpaces.Dto
{
    public class DialogSpaceDirectoryProvinceRelationDto : EntityDto
    {
        public string Name { get; set; }
        public DialogSpaceDirectoryDepartmentReverseDto Department { get; set; }
    }
}
