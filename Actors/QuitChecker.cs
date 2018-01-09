
namespace Kappa.Actors
{
    public class QuitChecker : IActor
    {
        private readonly Keyboard _keyboard;

        public QuitChecker(Keyboard keyboard)
        {
            _keyboard = keyboard;
        }

        public void Act()
        {
        }
    }
}
