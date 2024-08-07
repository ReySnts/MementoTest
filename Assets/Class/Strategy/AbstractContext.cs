using UnityEngine;

public abstract class AbstractContext<TStrategy> : MonoBehaviour
{
    [SerializeField] protected TStrategy strategy;

    public TStrategy Strategy => strategy;

    public virtual void SetStrategy(TStrategy strategy) => this.strategy = strategy;
}