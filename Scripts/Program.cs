﻿using System;

namespace LD48.Scripts
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new GameManager())
                game.Run();
        }
    }
}
