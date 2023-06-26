using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Race
{
    class Settings
    {
        public static int TimerSpeed;
        public static int CarTurnSpeed;
        public static bool IsGameOver;
        public static float GameSpeed;
        public static float MinSpeed;
        public static float MaxSpeed;
        public Settings()
        {
            TimerSpeed = 100;
            MinSpeed = 1;
            MaxSpeed = 21;
            GameSpeed = 1;
            CarTurnSpeed = 10;
            IsGameOver = false;
        }
    }
}
