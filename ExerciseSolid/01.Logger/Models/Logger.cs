using _01.Logger.Models.Interfaces;
using _01.Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models;

public class Logger
{
    private IList<IAppender> appenders;
    public Logger(params IAppender[] appenders)
    {
        this.appenders = appenders;
    }
    public IList<IAppender> Appenders { get => appenders; }
    public void Error(string dateTime, string message)
    {
        foreach (IAppender appender in appenders)
        {
            appender.Append(dateTime,ReportLevel.Error, message);
        }
    }
    public void Info(string dateTime, string message)
    {
        foreach (IAppender appender in appenders)
        {
            appender.Append(dateTime,ReportLevel.Info , message);
        }
    }
    public void Warning(string dateTime, string message)
    {
        foreach (IAppender appender in appenders)
        {
            appender.Append(dateTime, ReportLevel.Warning, message);
        }
    }
    public void Critical(string dateTime, string message)
    {
        foreach (IAppender appender in appenders)
        {
            appender.Append(dateTime, ReportLevel.Critical, message);
        }
    }
    public void Fatal(string dateTime, string message)
    {
        foreach (IAppender appender in appenders)
        {
            appender.Append(dateTime, ReportLevel.Fatal, message);
        }
    }
}
