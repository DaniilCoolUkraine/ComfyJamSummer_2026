namespace NarrativeGame.Interactions.Core.Samples
{
    public interface IInteractable
    {
        void CancelInteract(IInteractor interactor);
        void Interact(IInteractor interactor);
        bool CanInteract(IInteractor interactor);
    }
}