﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Contable.Application
{
    [Table("AppInterventionPlanStates")]
    public class InterventionPlanState : FullAuditedEntity
    {
        [Column(TypeName = InterventionPlanStateConsts.InterventionPlanIdType)]
        [ForeignKey("InterventionPlan")]
        public int InterventionPlanId { get; set; }
        public InterventionPlan InterventionPlan { get; set; }

        [Column(TypeName = InterventionPlanStateConsts.DescriptionType)]
        public string Description { get; set; }
    }
}
