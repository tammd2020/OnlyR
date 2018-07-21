﻿namespace OnlyR.Services.Options
{
    using System;
    using Fclp;

    // ReSharper disable once ClassNeverInstantiated.Global
    internal class CommandLineService : ICommandLineService
    {
        public CommandLineService()
        {
            var p = new FluentCommandLineParser();

            p.Setup<bool>("nogpu")
                .Callback(s => { NoGpu = s; }).SetDefault(false);

            p.Setup<string>("id")
                .Callback(s => { OptionsIdentifier = s; }).SetDefault(null);

            p.Parse(Environment.GetCommandLineArgs());
        }

        public bool NoGpu { get; set; }

        public string OptionsIdentifier { get; set; }
    }
}