
using Kappa.Data;
using Kappa.Util;

namespace Kappa.Actors
{
    public class QuitMenu : IActor
    {
        public QuitMenu(Keyboard keyboard, Ref<GameMode> mode, Ref<bool> quit)
        {
        }
        
        public void Act()
        {
            if( _mode.Value == GameMode.QuitMenu )
            {
            }
        }
    }

}
