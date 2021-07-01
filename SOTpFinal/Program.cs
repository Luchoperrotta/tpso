﻿using System;
using System.Threading;
using SOTpFinal.Controladores;

namespace SOTpFinal
{
    /*
     BIBLIOGRAFIA

        https://docs.microsoft.com/en-us/dotnet/api/system.threading?view=net-5.0
        https://www.c-sharpcorner.com/UploadFile/1d42da/thread-locking-in-C-Sharp/

     */
    class Program
    {

        static void Main(string[] args)
        {

            Control.inicializandoCorredores();

            Thread threadTortuga = new Thread(Control.carreraTortuga);
            threadTortuga.Start();

            Thread threadLiebre = new Thread(Control.carreraLiebre);
            threadLiebre.Start();
            Console.Read();
        }
    }
}