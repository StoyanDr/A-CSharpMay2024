using _01.Logger.Models.Enums;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models;

public class FileAppender : IAppender
{
    private readonly ILayout layout;
    private LogFile logFile;
    public FileAppender(ILayout layout, LogFile file)
    {
        this.layout = layout;
        this.logFile = file;
    }
    public int AppendedMessages { get; set; }
    public ReportLevel ReportLevel { get; set; }
    public void Append(string dateTime,ReportLevel level, string message)
    {
        if (level < ReportLevel) return;
        logFile.Write(layout.Output(dateTime, level, message));
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
        s += rLevel + $", Messages appended: {AppendedMessages}, File size: {logFile.Size}";
        return s;
    }
}
