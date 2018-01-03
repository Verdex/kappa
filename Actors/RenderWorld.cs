
using System.Collections.Generic;

using Kappa.Util;
using Kappa.Data;

namespace Kappa.Actors
{
    public class RenderWorld : IActor
    {
        private readonly Ref<GameMode> _gameMode;
        private readonly List<IRenderable> _renderObjects;
        public RenderWorld(Ref<GameMode> gameMode, List<IRenderable> renderObjects)
        {
            _gameMode = gameMode;
            _renderObjects = renderObjects;
        }

        public void Act()
        {
            if ( _gameMode.Value != GameMode.World )
            {
                return;
            }

            
        }
    }
}
