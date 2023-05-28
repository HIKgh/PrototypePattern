﻿using Application;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace PrototypePattern;

public class Program
{
    static void Main(string[] args)
    {
        var provider = DependencyInjection.ConfigureServices();
        var service = provider.GetRequiredService<IPrototypePatternService>();
        service.Process();
    }
}