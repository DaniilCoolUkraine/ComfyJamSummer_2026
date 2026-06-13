using SimpleEventBus.SimpleEventBus.Runtime;

namespace TempWorker.Interactions.Core
{
    internal class InteractableChangedEvent : IEvent
    {
        public IInteractable Interactable { get; }
        public IInteractor Interactor { get; }

        public InteractableChangedEvent(IInteractable interactable, IInteractor interactor)
        {
            Interactable = interactable;
            Interactor = interactor;
        }
    }
}