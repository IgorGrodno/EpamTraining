﻿using ParsingLevel.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ManagersService
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
#if (DEBUG == true)

            ManagersService service = new ManagersService();
            service.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
            
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {

                new ManagersService()

            };
            ServiceBase.Run(ServicesToRun);
#endif
        }

    }
}
