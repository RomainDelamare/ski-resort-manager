using System;

namespace SkiResortManager.Backoffice.Shared.Events
{
    public class LockPageEvent
    {
        public event Action OnPageLock;
        public event Action OnPageUnlock;

        public void LockPage() => OnPageLock.Invoke();
        public void UnlockPage() => OnPageUnlock.Invoke();
    }
}
