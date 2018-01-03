
using Kappa.Util;
using Kappa.Data;

namespace Kappa.Actors
{
    public class RenderWorld : IActor
    {
        private readonly Ref<GameMode> _gameMode;
        public RenderWorld(Ref<GameMode> gameMode)
        {
            _gameMode = gameMode;
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
