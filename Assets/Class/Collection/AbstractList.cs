using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractList<TItem> : MonoBehaviour
{
    protected List<TItem> list = new();

    public List<TItem> List => list;

    protected abstract void Awake();

    protected void OnDestroy() => list.Clear();
}