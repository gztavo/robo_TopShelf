using System;
using System.Collections.Generic;
using System.Text;
using Topshelf;

namespace Robo
{
    public class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<RoboService>(service =>
                {
                    service.ConstructUsing(s => new RoboService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                   
                    configure.RunAsLocalSystem();
                configure.SetServiceName("RobôComTopshelf");
                configure.SetDisplayName("RobôComTopshelf");
                configure.SetDescription("Robô com Topshelf");
            });
        }
    }
}

