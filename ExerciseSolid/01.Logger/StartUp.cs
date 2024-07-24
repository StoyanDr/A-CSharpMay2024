using _01.Logger.Models;
using _01.Logger.Models.Enums;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Logger;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<IAppender> appenders = new();
        string[] input;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (input.Length == 2)
            {
                ILayout layout;
                IAppender appender;
                if (input[1].ToLower().Contains("simple")) layout = new SimpleLayout();
                else layout = new XmlLayout();
                if (input[0].ToLower().Contains("console"))
                {
                    appender = new ConsoleAppender(layout);
                }
                else
                {
                    LogFile file = new();
                    appender = new FileAppender(layout, file);
                }
                appenders.Add(appender);
            }
            else
            {
                ILayout layout;
                IAppender appender;
                ReportLevel level = ReportLevel.Fatal;
                if (input[1].ToLower().Contains("simple")) layout = new SimpleLayout();
                else layout = new XmlLayout();
                switch (input[2].ToLower())
                {
                    case "info": level = ReportLevel.Info; break;
                    case "warning": level = ReportLevel.Warning; break;
                    case "error": level = ReportLevel.Error; break;
                    case "critical": level = ReportLevel.Critical; break;
                    case "fatal": level = ReportLevel.Fatal; break;
                }
                if (input[0].ToLower().Contains("console")) appender = new ConsoleAppender(layout);
                else
                {
                    LogFile file = new();
                    appender = new FileAppender(layout, file);
                }
                appender.ReportLevel = level;
                appenders.Add(appender);
            }
        }
        Logger logger = new Logger(appenders.ToArray());
        string line;
        while ((line = Console.ReadLine()) != "END")
        {
            input = line.Split('|', StringSplitOptions.RemoveEmptyEntries);
            switch(input[0].ToLower())
            {
                case "info":
                    logger.Info(input[1], input[2]);
                    break;
                case "warning":
                    logger.Warning(input[1], input[2]);
                    break;
                case "error":
                    logger.Error(input[1], input[2]);
                    break;
                case "critical":
                    logger.Critical(input[1], input[2]);
                    break;
                case "fatal":
                    logger.Fatal(input[1], input[2]);
                    break;
            }
        }
        foreach(var appender in logger.Appenders)
        {
            Console.WriteLine(appender.ToString());
        }
    }
}
