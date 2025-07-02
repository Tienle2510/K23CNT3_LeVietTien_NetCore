using System;
using System.Collections.Generic;

namespace Lvt_2310900103.Models;

public partial class LvtEmployee
{
    public int LvtEmpId { get; set; }

    public string? LvtEmpName { get; set; }

    public int? LvtEmpLevel { get; set; }

    public DateOnly? LvtEmpStartDate { get; set; }

    public bool? LvtEmpStatus { get; set; }
}
