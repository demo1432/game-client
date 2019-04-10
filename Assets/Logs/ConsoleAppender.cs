using log4net.Appender;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using log4net.Core;
using System;

public class ConsoleAppender : AppenderSkeleton
{
    protected override void Append(LoggingEvent loggingEvent)
    {
        string msg = this.RenderLoggingEvent(loggingEvent);
        if (loggingEvent.Level == Level.Error)
        {
            Debug.LogError(msg);
        }
        else if (loggingEvent.Level == Level.Warn)
        {
            Debug.LogWarning(msg);
        }
        else
        {
            Debug.Log(msg);
        }
    }
}
