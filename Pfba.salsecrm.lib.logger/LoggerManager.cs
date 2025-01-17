﻿using System;
using System.Collections.Generic;
using System.Linq;
using NLog;

namespace Pfba.salsecrm.lib.logger;

public class LoggerManager : ILoggerManager
{
    private static ILogger logger = LogManager.GetCurrentClassLogger();
        public LoggerManager()
        {
        }

        public bool IsFatalEnabled
        {
            get { return logger.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return logger.IsDebugEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return logger.IsDebugEnabled; }
        }

        public bool IsDebugEnabled
        {
            get { return logger.IsDebugEnabled; }
        }

        public bool IsTraceEnabled
        {
            get { return logger.IsDebugEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return logger.IsDebugEnabled; }
        }

        public void Error(Exception exception, String message)
        {
            logger.Error(exception, message);
        }

        public void Debug(Exception exception, String message)
        {
            logger.Debug(exception, message);
        }

        public void Fatal(Exception exception, String message)
        {
            logger.Fatal(exception, message);
        }

        public void Debug<T>(T value)
        {
            logger.Debug(value);
        }

        public void Debug<T>(IFormatProvider formatProvider, String message, T argument)
        {
            logger.Debug(formatProvider, message, argument);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            logger.Debug<TArgument1, TArgument2, TArgument3>(message, argument1, argument2, argument3);
        }

        public void Debug(Object value)
        {
            logger.Debug(value);
        }

        public void Debug(LogMessageGenerator messageFunc)
        {
            logger.Debug(messageFunc);
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
            logger.Debug<T>(formatProvider, value);
        }

        public void Error<T>(String message, T argument)
        {
            logger.Error(message, argument);
        }

        public void Error<T>(IFormatProvider formatProvider, String message, T argument)
        {
            logger.Error(formatProvider, message, argument);
        }

        public void Error(System.String message, System.Object arg1, System.Object arg2, System.Object arg3)
        {
            logger.Error(message, arg1, arg2, arg3);
        }

        public void Trace(IFormatProvider formatProvider, String message, Object argument)
        {
            logger.Trace(formatProvider, message, argument);
        }

        public void Trace<T>(String message, T argument)
        {
            logger.Trace(message, argument);
        }

        public void Trace(Object value)
        {
            logger.Trace(value);
        }

        public void Trace<T>(IFormatProvider formatProvider, T value)
        {
            logger.Trace(formatProvider, value);
        }

        public void Trace(LogMessageGenerator messageFunc)
        {
            logger.Trace(messageFunc);
        }

        public void Info(Object value)
        {
            logger.Info(value);
        }

        public void Warn(Object value)
        {
            logger.Warn(value);
        }

        public void Warn(String message, SByte argument)
        {
            logger.Warn(message, argument);
        }

        public void Error(Object value)
        {
            logger.Error(value);
        }

        public void Fatal(Object value)
        {
            logger.Fatal(value);
        }

        public void Log(LogEventInfo logEvent)
        {
            logger.Log(logEvent);
        }
}
