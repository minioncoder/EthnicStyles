using Autofac;
using EthnicStyles.DataAccess.EthnicInterfaces;

namespace EthnicStyles.DataAccess
{
    public class AutofacComponent
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EthnicStyleRepository>().As<IEthnicStyleRepository>();
            Container = builder.Build();
        }
    }
}
