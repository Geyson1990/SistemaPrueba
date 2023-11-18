﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Contable.Application
{
    [Table("AppSocialConflictTaskManagementPersons")]
    public class SocialConflictTaskManagementPerson : Entity
    {
        [Column(TypeName = SocialConflictTaskManagementPersonConsts.SocialConflictTaskManagementIdType)]
        [ForeignKey("SocialConflictTaskManagement")]
        public int SocialConflictTaskManagementId { get; set; }
        public SocialConflictTaskManagement SocialConflictTaskManagement { get; set; }

        [Column(TypeName = SocialConflictTaskManagementPersonConsts.PersonIdType)]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
