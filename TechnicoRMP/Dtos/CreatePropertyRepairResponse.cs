﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicoRMP.Models;

namespace TechnicoRMP.Dtos;

public class CreatePropertyRepairResponse : IDto
{
    public long Id { get; set; }
    public DateTime? Date { get; set; }
    public EnTypeOfRepair TypeOfRepair { get; set; }
    public required string Address { get; set; }
    public EnRepairStatus RepairStatus { get; set; }
    public decimal Cost { get; set; }
    public long RepairerId { get; set; }
    public bool IsActive { get; set; }
}
