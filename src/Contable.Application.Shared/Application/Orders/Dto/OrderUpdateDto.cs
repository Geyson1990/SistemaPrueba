﻿using Abp.Application.Services.Dto;

namespace Contable.Application.Orders.Dto
{
    public class OrderUpdateDto : EntityDto<long>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public OrderType Type { get; set; }

        public string Description { get; set; }

        public string Observation { get; set; }

        public string Document { get; set; }

        public string Responsible { get; set; }

        public OrderPIPMEFUpdateDto PIPMEF { get; set; }

        public OrderSocialConflictDto SocialConflict { get; set; }

        public OrderTerritorialUnitDto TerritorialUnit { get; set; }
        public OrderDepartmentDto Department { get; set; }
        public OrderProvinceDto Province { get; set; }
        public OrderDistrictDto District { get; set; }
    }
}
