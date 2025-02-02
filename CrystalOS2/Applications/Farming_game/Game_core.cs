﻿using Cosmos.Core.IOGroup;
using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalOS2.Applications.Farming_game
{
    public class Game_core
    {
        [ManifestResourceStream(ResourceName = "CrystalOS2.Applications.Farming_game.Garden.bmp")] public static byte[] Garden;
        public static Bitmap Garden_map = new Bitmap(Garden);

        public static string current_board = "main";

        public static void Core(int x, int y)
        {
            #region Drawing the game board
            if(current_board == "main")
            {
                ImprovedVBE.DrawImageAlpha(Garden_map, x, y);
            }
            #endregion Drawing the game board

            #region Game engine
            if(current_board == "main")
            {
                if(MouseManager.MouseState == MouseState.Left)
                {
                    if(Kernel.Y > y + 193 && Kernel.Y < y + 324)
                    {
                        if (Kernel.X > x + 397 && Kernel.X < x + 528)
                        {
                            ImprovedVBE._DrawACSIIString("It is a garden1!", 900, 900, 16777215);
                        }
                        else if (Kernel.X > x + 589 && Kernel.X < x + 720)
                        {
                            ImprovedVBE._DrawACSIIString("It is a garden2!", 900, 900, 16777215);
                        }
                        else if (Kernel.X > x + 777 && Kernel.X < x + 908)
                        {
                            ImprovedVBE._DrawACSIIString("It is a garden3!", 900, 900, 16777215);
                        }
                    }
                    else if (Kernel.Y > y + 470 && Kernel.Y < y + 601)
                    {
                        if (Kernel.X > x + 397 && Kernel.X < x + 528)
                        {
                            ImprovedVBE._DrawACSIIString("It is a garden4!", 900, 900, 16777215);
                        }
                        else if (Kernel.X > x + 589 && Kernel.X < x + 720)
                        {
                            ImprovedVBE._DrawACSIIString("It is a garden5!", 900, 900, 16777215);
                        }
                        else if (Kernel.X > x + 777 && Kernel.X < x + 908)
                        {
                            ImprovedVBE._DrawACSIIString("It is a garden6!", 900, 900, 16777215);
                        }
                    }
                }
            }
            #endregion Game engine
        }
    }
}
