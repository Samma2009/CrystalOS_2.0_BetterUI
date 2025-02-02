﻿using Cosmos.System;
using Cosmos.System.Graphics;
using CrystalOS2.Applications.Task_Scheduler;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalOS2.Gameboy
{
    class Game_selector
    {
        [ManifestResourceStream(ResourceName = "CrystalOS2.Gameboy.Collection.bmp")] public static byte[] app;
        public static Bitmap Window = new Bitmap(app);

        public static void Game_selector_(int x, int y)
        {
            ImprovedVBE.DrawImageAlpha(Window, x, y);

            if(MouseManager.MouseState == MouseState.Left)
            {
                if (Kernel.X > Task_Manager.Tasks[Task_Manager.indicator].Item2 + 623 && Kernel.X < Task_Manager.Tasks[Task_Manager.indicator].Item2 + 644)
                {
                    if (Kernel.Y > Task_Manager.Tasks[Task_Manager.indicator].Item3 + 8 && Kernel.Y < Task_Manager.Tasks[Task_Manager.indicator].Item3 + 24)
                    {
                        //Bool_Manager.Settings_Opened = false;
                        Task_Manager.Tasks.RemoveAt(Task_Manager.indicator);
                    }
                }
                if (Task_Manager.Tasks[Task_Manager.indicator].Item4 == false)
                {
                    if (Kernel.X > x && Kernel.X < x + 570)
                    {
                        if (Kernel.Y > y && Kernel.Y < y + 18)
                        {
                            int f = (int)Kernel.X;
                            int g = (int)Kernel.Y;
                            Task_Manager.Tasks.RemoveAt(Task_Manager.indicator);
                            Task_Manager.Tasks.Insert(0, new Tuple<string, int, int, bool, string, bool, int>("Gameboy", f, g, true, "", true, CrystalOS2.Applications.MultiDesk.Core.Current_Desktop));
                        }
                    }
                }

                if(Kernel.Y > y + 23 && Kernel.Y < y + 182)
                {
                    if(Kernel.X > x + 10 && Kernel.X < x + 132)
                    {
                        CrystalOS2.Kernel.power_on = true;
                        CrystalOS2.Kernel.show_gb = true;
                        CrystalOS2.Kernel.gamenum = 1;
                    }
                    if (Kernel.X > x + 133 && Kernel.X < x + 255)
                    {
                        CrystalOS2.Kernel.power_on = true;
                        CrystalOS2.Kernel.show_gb = true;
                        CrystalOS2.Kernel.gamenum = 3;
                    }
                    if (Kernel.X > x + 256 && Kernel.X < x + 378)
                    {
                        CrystalOS2.Kernel.power_on = true;
                        CrystalOS2.Kernel.show_gb = true;
                        CrystalOS2.Kernel.gamenum = 0;
                    }
                    if (Kernel.X > x + 379 && Kernel.X < x + 502)
                    {
                        CrystalOS2.Kernel.power_on = true;
                        CrystalOS2.Kernel.show_gb = true;
                        CrystalOS2.Kernel.gamenum = 2;
                    }
                    if (Kernel.X > x + 503 && Kernel.X < x + 625)
                    {
                        CrystalOS2.Kernel.power_on = true;
                        CrystalOS2.Kernel.show_gb = true;
                        CrystalOS2.Kernel.gamenum = 4;
                    }
                }
            }

            if (Task_Manager.Tasks[Task_Manager.indicator].Item4 == true)
            {
                int f = (int)Kernel.X;
                int g = (int)Kernel.Y;
                Task_Manager.Tasks.RemoveAt(0);
                Task_Manager.Tasks.Insert(0, new Tuple<string, int, int, bool, string, bool, int>("Gameboy", f, g, true, "", true, CrystalOS2.Applications.MultiDesk.Core.Current_Desktop));
                if (MouseManager.MouseState == MouseState.Right)
                {
                    Task_Manager.Tasks.RemoveAt(0);
                    Task_Manager.Tasks.Insert(0, new Tuple<string, int, int, bool, string, bool, int>("Gameboy", f, g, false, "", true, CrystalOS2.Applications.MultiDesk.Core.Current_Desktop));
                    Task_Manager.Tasks.Reverse();
                    //movable = false;
                }

                if (Kernel.X > x && Kernel.X < x + 352)
                {
                    if (Kernel.Y > y && Kernel.Y < y + 18)
                    {
                        //movable = false;
                    }
                }

            }
        }
    }
}