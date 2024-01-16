using Runtime.DependencyInjection;
using Runtime.SignalBus.Controller;

namespace Runtime.SignalBus.Installer
{
    public class SignalInstaller : DiInstaller
    {
        public override void Install()
        {
            DiContainer.Bind<SignalController>();
        }
    }
}