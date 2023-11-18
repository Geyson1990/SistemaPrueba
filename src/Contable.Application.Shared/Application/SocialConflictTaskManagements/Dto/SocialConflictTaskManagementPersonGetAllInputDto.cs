﻿using Abp.Extensions;
using Abp.Runtime.Validation;
using Contable.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application.SocialConflictTaskManagements.Dto
{
    public class SocialConflictTaskManagementPersonGetAllInputDto : PagedAndSortedInputDto, IShouldNormalize
    {
        public string Document { get; set; }
        public string EmailAddress { get; set; }
        public string Names { get; set; }
        public int SocialConflictTaskManagementId { get; set; }

        public void Normalize()
        {
            if (Sorting.IsNullOrWhiteSpace())
            {
                Sorting = "Name DESC";
            }
        }
    }
}
