
using System;

using Kappa.Data;

namespace Kappa.Actors
{
    public class KeyPressUpdater : IActor
    {
        private readonly Keyboard _keyboard;
        public KeyPressUpdater(Keyboard keyboard)
        {
            _keyboard = keyboard;
        }

        public void Act()
        {
            var key = Console.ReadKey( true );
            _keyboard.LastChar = key.KeyChar;
        }
    }
}
