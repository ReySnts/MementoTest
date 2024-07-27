using UnityEngine;

public abstract class AbstractCommander : MonoBehaviour
{
    protected abstract void Awake();

    public abstract void Execute(ICommand command);

    public abstract void UndoCommand();
}