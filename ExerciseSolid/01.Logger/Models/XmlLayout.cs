﻿using _01.Logger.Models.Enums;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models;

public class XmlLayout : ILayout
{
    public string Output(string dateTime, ReportLevel level, string message)
    {
        string rLevel = string.Empty;
        switch (level)
        {
            case ReportLevel.Info:
                rLevel = "Info";
                break;
            case ReportLevel.Warning:
                rLevel = "Warning";
                break;
            case ReportLevel.Error:
                rLevel = "Error";
                break;
            case ReportLevel.Critical:
                rLevel = "Critical";
                break;
            case ReportLevel.Fatal:
                rLevel = "Fatal";
                break;
        }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("<log>");
        sb.AppendLine($"    <date>{dateTime}</date>");
        sb.AppendLine($"    <level>{rLevel}</level>");
        sb.AppendLine($"    <message>{message}</message>");
        sb.Append("</log>");
        return sb.ToString();
    }
}
