
namespace Kappa.Actors
{
    public class QuitChecker : IActor
    {
        private readonly Keyboard _keyboard;
        private readonly Ref<GameMode> _mode;

        public QuitChecker(Keyboard keyboard, Ref<GameMode> mode)
        {
            _keyboard = keyboard;
            _mode = mode;
        }

        public void Act()
        {
            if ( _keyboard.LastChar == 'q' )
            {
                _mode = QuitMenu; 
            }
        }
    }
}
