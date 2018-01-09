
using System.Collections.Generic;

using Kappa.Util;

namespace Kappa.Data
{
    public class State
    {
        public Keyboard Keyboard { get; set; }
        public Ref<GameMode> GameMode { get; set; } // TODO add quit game mode
        public List<IRenderable> RenderObjects { get; set; }
    }
}
