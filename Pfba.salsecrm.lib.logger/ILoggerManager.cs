#region Namespace
using System;
using System.Collections.Generic;
using NLog;
#endregion
namespace Pfba.salsecrm.lib.logger;

interface ILoggerManager
{
    void Error(Exception exception, string message);
    void Debug(Exception exception, string message);
    void Fatal(Exception exception, string message);
    void Debug<T>(T value);
    void Debug<T>(IFormatProvider formatProvider, String message, T argument);
    void Debug<TArgument1, TArgument2,TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
    void Debug(object value);
    void Debug(LogMessageGenerator messageFunc);
    void Debug<T>(IFormatProvider formatProvider, T value);
    void Error<T>(string message, T argument);
    void Error<T>(IFormatProvider formatProvider, string message, T argument);
    void Error(string message,object argument1, object argument2, object argument3);
    void Trace(IFormatProvider formatProvider,string message,object argument);
    void Trace<T>(string message, T argument);
    void Trace(object value);
    void Trace<T> (IFormatProvider formatProvider,T value);
    void Trace(LogMessageGenerator messageFunc);
    void Info(object value);
    void Warn(object value);
    void Warn(string message,SByte argument);
    void Error(object value);
    void Fatal(object value);
    void Log(LogEventInfo logEventInfo);    
}
