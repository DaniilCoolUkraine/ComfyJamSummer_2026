using SimpleEventBus.SimpleEventBus.Runtime;

namespace NarrativeGame.Interactions.Core.Samples
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