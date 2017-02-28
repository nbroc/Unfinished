using System;
using LeagueSharp;
using LeagueSharp.Common;

namespace JannaSharp
{
    internal class Q : Bootstrap.IBootstrap
    {
        public static Spell spellQ;

        private bool IsCharging { get; set; } = ObjectManager.Player.HasBuff("JANNABUFFNAME");

        public void Init()
        {
            spellQ = new Spell(SpellSlot.Q);
            spellQ.SetCharged("", "", 1, 1, 1f);

            Game.OnUpdate += OnTick;
        }

        private void OnTick(EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
        