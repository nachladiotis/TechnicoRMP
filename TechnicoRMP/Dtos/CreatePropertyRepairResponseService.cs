﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicoRMP.Models;

namespace TechnicoRMP.Dtos;

public class CreatePropertyRepairResponseService
{
    public static CreatePropertyRepairResponse CreateFromEntity(PropertyRepair propertyRepair)
    {
        return new CreatePropertyRepairResponse {
            RepairStatus = propertyRepair.RepairStatus,
            Address = propertyRepair.Address,
            Cost = propertyRepair.Cost,
            Date = propertyRepair.Date,
            Id = propertyRepair.Id,
            IsActive = propertyRepair.IsActive,
            RepairerId = propertyRepair.RepairerId,
            TypeOfRepair = propertyRepair.TypeOfRepair,
        };
    }
}
