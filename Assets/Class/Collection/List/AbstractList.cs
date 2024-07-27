using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractList<TItem> : MonoBehaviour
{
    [SerializeField] protected List<TItem> list = new();

    public List<TItem> List => list;

    protected abstract void Awake();

    protected virtual void OnDestroy() => list.Clear();
}