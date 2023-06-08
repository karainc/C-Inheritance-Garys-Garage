// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Garage {
    class Program {
        
        static void Main (string[] args) {
            Zero fxs = new Zero ();
            Zero fx = new Zero ();
            Tesla modelS = new Tesla ();
            Cessna mx410 = new Cessna();
            Ram d4000 = new Ram ();

        //fxs.Drive();
            //modelS.Drive();
            //mx410.Drive();
         //Define a different value for each vehicle's properties.
        fxs.MainColor = "blue";
        modelS.MainColor = "red";
        mx410.MainColor = "gray";
        d4000.MainColor = "white";

        fxs.Drive();
        modelS.Drive();
        mx410.Drive();
        d4000.Drive();
        Console.WriteLine("");

       d4000.Turn("");
       fxs.Turn("");
        modelS.Turn("");
        mx410.Turn("");
        Console.WriteLine("");

        d4000.Stop();
        fxs.Stop();
        modelS.Stop();
        mx410.Stop();
        Console.WriteLine("");



        }
    }
}