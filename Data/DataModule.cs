using Microsoft.Practices.Unity;
using Spread.Betting.Data.Interfaces;

namespace Spread.Betting.Data
{
    public class DataModule : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IDataContext, DataContext>();
            Container.RegisterType<IDataCommand, DataCommand>();
        }
    }
}
