using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceCore.Events;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StaminaSkill
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/

        private static StardewModdingAPI.Mod instance;
        private const int runGain = 1;
        private const int toolGain = 3;

        public static readonly int[] expNeededForLevel = new int[10]
        {
            100,
            380,
            770,
            1300,
            2150,
            3300,
            4800,
            6900,
            10000,
            15000
        };



        public static void addStaminaExp(int amount)
        {
            if (amount < 0)
            {
                return;
            }

           
        }

        private void update(object sender, EventArgs args)
        {

        }

        /*********
        ** Private methods
        *********/
        /// <summary>The method invoked when the player presses a controller, keyboard, or mouse button.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void InputEvents_ButtonPressed(object sender, EventArgsInput e)
        {
            if (Context.IsWorldReady) // save is loaded
            {
                this.Monitor.Log($"{Game1.player.name} pressed {e.Button}.");
            }

            
        }

        public override void Entry(IModHelper helper)
        {

            ModEntry.instance = this;

        }


        public ModEntry()
        {
            
        }
    }
}