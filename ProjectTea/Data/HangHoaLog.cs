using System;
using System.Collections.Generic;

namespace ProjectTea.Data;

public partial class HangHoaLog
{
    public int LogId { get; set; }

    public int? MaHh { get; set; }

    public string? Action { get; set; }

    public DateTime? ChangeDate { get; set; }

    public string? Details { get; set; }
}
