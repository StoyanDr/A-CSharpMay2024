using _01.Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models.Interfaces;

public interface IAppender
{
    public ReportLevel ReportLevel { get; set; }
    public int AppendedMessages { get; set; }
    void Append(string dateTime, ReportLevel level, string message);
}

