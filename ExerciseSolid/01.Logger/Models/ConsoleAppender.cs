using _01.Logger.Models.Enums;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models;

public class ConsoleAppender : IAppender
{
    private readonly ILayout layout;
    public ConsoleAppender(ILayout layout)
    {
        this.layout = layout;
    }

    public ReportLevel ReportLevel { get; set; }
    public int AppendedMessages { get; set; }
    public void Append(string dateTime, ReportLevel level, string message)
    {
        if (level < ReportLevel) return;
        Console.WriteLine(layout.Output(dateTime, level, message));
        AppendedMessages++;
    }
    public override string ToString()
    {
        string s = $"Appender type: FileAppender, LayoutType: {layout.GetType().Name}, Report level: ";
        string rLevel = string.Empty;
        switch (ReportLevel)
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
        s += rLevel + $", Messages appended: {AppendedMessages}";
        return s;
    }
}
