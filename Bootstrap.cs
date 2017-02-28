using System;
using System.Collections.Generic;
using LeagueSharp;
using LeagueSharp.Common;

namespace JannaSharp
{
    class Bootstrap
    {
        public List<IBootstrap> BootStrap = new List<IBootstrap> {new Q(), new E(), new W(), new OnDraw()};

        public interface IBootstrap
        {
            void Init();
        }


        public Bootstrap()
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private void Game_OnGameLoad(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName != "Janna")
            {
                return;
            }

            BootStrap.ForEach(bootstrap => bootstrap.Init());
        }
    }
}
