﻿namespace CakeHttp
{
    public interface ICakeHttpInitOptions
    {
        string BaseUrl { get; }
        bool CamelCasePathAndQuery { get; set; }
        EnumSerialization EnumSerialization { get; set; }
        Func<string, string> PathAndQueryFormatter { get; }
    }
}