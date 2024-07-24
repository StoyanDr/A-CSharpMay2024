using _01.Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models.Interfaces;

public interface ILayout
{
    string Output(string dateTime, ReportLevel level, string message);
}
