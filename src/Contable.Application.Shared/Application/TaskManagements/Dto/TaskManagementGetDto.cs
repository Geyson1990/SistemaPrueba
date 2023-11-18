﻿using Abp.Application.Services.Dto;
using Contable.Application.Compromises.Dto;
using Contable.Application.ResponsibleActors.Dto;
using Contable.Application.SocialConflictTaskManagements.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.TaskManagements.Dto
{
    public class TaskManagementGetDto : EntityDto<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? Deadline { get; set; }
        public TaskStatus Status { get; set; }
        public string Responsible { get; set; }        
        public CompromiseGetDto Compromise { get; set; }
        public List<TaskManagementPersonRelationDto> Persons { get; set; }
        public List<TaskManagementCommentGetDto> Comments { get; set; }
    }
}
