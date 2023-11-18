﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contable.Application
{
    public class SectorMeetSessionSummaryConsts
    {
        public const string SectorMeetSessionIdType = "INT";
        public const string SectorMeetSessionLeaderIdType = "INT";
        
        public const int DescriptionMinLength = 0;
        public const int DescriptionMaxLength = 5000;
        public const string DescriptionType = "VARCHAR(5000)";

        public const string IndexType = "INT";
    }
}
