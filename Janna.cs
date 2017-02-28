using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace JannaSharp
{
    class Janna
    {
        public Janna()
        {
            Program.Menu = new Menu(ObjectManager.Player.ChampionName, ObjectManager.Player.ChampionName, true);
            Program.Menu.AddToMainMenu();
            Menu Spells = Program.Menu.AddSubMenu(new Menu("Spells", "Spells"));
            {
                Menu Q = Spells.AddSubMenu(new Menu("Q", "Q"));
                {
                    Q.AddItem(
                            new MenuItem(JannaSharp.Q.spellQ + "Combo",JannaSharp.Q.spellQ + "Combo").SetValue(true));
                    Q.AddItem(
                        new MenuItem(JannaSharp.Q.spellQ + "Mana",JannaSharp.Q.spellQ + "Mana").SetValue(
                            new Slider(30)));

                    }
                Menu W = Spells.AddSubMenu(new Menu("W", "W"));
                {
                    foreach (var ally in ObjectManager.Get<Obj_AI_Hero>().Where(x => x.IsAlly || x.IsMe))
                    {
                        W.AddItem(
                            new MenuItem(JannaSharp.E.spellE + "Combo", JannaSharp.W.spellW + "Combo").SetValue(true));
                        W.AddItem(
                            new MenuItem(JannaSharp.E.spellE + "Mana", JannaSharp.W.spellW + "Mana").SetValue(
                                new Slider(30)));
                        W.AddItem(
                            new MenuItem(
                                "Use" + JannaSharp.W.spellW + ":" + JannaSharp.W.spellW + ally.ChampionName,
                                "Use" + JannaSharp.W.spellW + ":" + JannaSharp.W.spellW + ally.ChampionName)
                                .SetValue(true));
                    }
                    Menu E = Spells.AddSubMenu(new Menu("E", "E"));
                    {
                        foreach (var ally in ObjectManager.Get<Obj_AI_Hero>().Where(x => x.IsAlly || x.IsMe))
                        {
                            E.AddItem(
                                new MenuItem(JannaSharp.E.spellE + "AA Protector", JannaSharp.E.spellE + "AA Protector").SetValue(true));
                           E .AddItem(
                                new MenuItem(JannaSharp.E.spellE + "Targeted Spell Protector",JannaSharp.E.spellE + "Targeted Spell Protector").SetValue(true));
                           E .AddItem(
                                new MenuItem(JannaSharp.E.spellE + "Combo",JannaSharp.E.spellE + "Combo").SetValue(true));
                            E.AddItem(
                                new MenuItem(JannaSharp.E.spellE + "Combo", JannaSharp.E.spellE + "Combo").SetValue(
                                    new Slider(1)));
                            E.AddItem(
                                new MenuItem(
                                    "Use" + JannaSharp.E.spellE + ":" + JannaSharp.E.spellE + ally.ChampionName,
                                    "Use" + JannaSharp.E.spellE + ":" + JannaSharp.E.spellE + ally.ChampionName)
                                    .SetValue(true));
                        }
                    }
                }
            }
        }
    }
}
