﻿using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Model model = new Model();

            Controller controller = new Controller(model);  

            IView view = new View(controller, model);

            controller.Start(view);
        }
    }
}