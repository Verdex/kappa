
using System.Collections.Generic;

using Kappa.Util;

namespace Kappa.Data
{
    public class State
    {
        public Keyboard Keyboard { get; set; }
        public Ref<GameMode> GameMode { get; set; } 
        public List<IRenderable> RenderObjects { get; set; }
        public Ref<bool> Quit { get; set; } 
    }
}
