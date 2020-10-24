using MediatR;
using SkiResortManager.Backoffice.Shared.Events;
using System.Threading;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice.Shared.Processing.Decorators
{
    public class LockPageRequestWithResultDecorator<T, TResult> : IRequestHandler<T, TResult> where T : IRequest<TResult>
    {
        private readonly IRequestHandler<T, TResult> _decorated;
        private readonly LockPageEvent _lockPageEvent;

        public LockPageRequestWithResultDecorator(IRequestHandler<T, TResult> decorated, LockPageEvent lockPageEvent)
        {
            _decorated = decorated;
            _lockPageEvent = lockPageEvent;
        }

        public async Task<TResult> Handle(T request, CancellationToken cancellationToken)
        {
            _lockPageEvent.LockPage();

            var result = await _decorated.Handle(request, cancellationToken);

            _lockPageEvent.UnlockPage();

            return result;
        }
    }
}
