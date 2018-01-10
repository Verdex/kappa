
using System;
using System.Linq;
using System.Collections.Generic;

using Kappa.Data;

namespace Kappa.Actors
{
    // TODO save game util?
    public class Director
    {
        private IEnumerable<Func<State, IActor>> BuildActors
        {
            get 
            {
                yield return s => new KeyPressUpdater( s.Keyboard );
                yield return s => new RenderWorld( s.GameMode, s.RenderObjects );
                // TODO render save game menu
            }
        }

        private readonly State _state;
        private List<IActor> _actors; 

        public Director(State state)
        {
            _state = state;
            _actors = BuildActors.Select( builder => builder(state) ).ToList();
        }

        public void RunActors()
        {
            while( true ) // TODO
            {
                foreach( var actor in _actors )
                {
                    actor.Act();
                }
            }
            // TODO save game ? 
        }
    }
}
