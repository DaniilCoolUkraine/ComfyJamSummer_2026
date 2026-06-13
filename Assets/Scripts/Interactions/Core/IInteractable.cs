namespace TempWorker.Interactions.Core
{
    public interface IInteractable
    {
        void CancelInteract(IInteractor interactor);
        void Interact(IInteractor interactor);
        bool CanInteract(IInteractor interactor);
    }
}