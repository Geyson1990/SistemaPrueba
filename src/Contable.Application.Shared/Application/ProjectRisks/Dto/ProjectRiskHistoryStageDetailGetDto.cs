﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.ProjectRisks.Dto
{
    public class ProjectRiskHistoryStageDetailGetDto : EntityDto
    {
        public ProjectRiskHistoryStaticVariableGetDto StaticVariable { get; set; }
    }
}
