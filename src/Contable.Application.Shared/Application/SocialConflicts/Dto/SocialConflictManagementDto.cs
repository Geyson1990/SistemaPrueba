﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.SocialConflicts.Dto
{
    public class SocialConflictManagementDto : EntityDto
    {
        public string Name { get; set; }
        public bool ShowDetail { get; set; }
    }
}
