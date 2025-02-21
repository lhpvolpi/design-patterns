﻿namespace Designer.Patterns.Singleton;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new Logger();
            }

            return _instance;
        }
    }

    public void Log(string message)
        => Console.WriteLine(message);
}