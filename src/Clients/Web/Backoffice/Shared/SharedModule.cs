using Autofac;
using MediatR;
using SkiResortManager.Backoffice.Shared.Events;
using SkiResortManager.Backoffice.Shared.Processing.Decorators;

namespace SkiResortManager.Backoffice.Shared
{
    public class SharedModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<LockPageEvent>()
                .SingleInstance();

            builder.RegisterGenericDecorator(
                typeof(LockPageRequestWithResultDecorator<,>),
                typeof(IRequestHandler<,>));
        }
    }
}
