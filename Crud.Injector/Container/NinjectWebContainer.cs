using Ninject;
using Crud.IServices;
using Services;
using Crud.IServices.Command;
using Services.Command;

namespace Crud.Injector.Container
{
    public class NinjectWebContainer
    {
        public static void Container(IKernel kernel)
        {
            kernel.Bind<ICustomerQueryService>().To<CustomerQueryService>().InThreadScope();
            kernel.Bind<ICustomerCommandService>().To<CustomerCommandService>().InThreadScope();
        }
    }
}
