﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.DinamicVariables.Dto
{
    public class DinamicVariableUpdateDto : EntityDto
    {
        public string Name { get; set; }
    }
}
