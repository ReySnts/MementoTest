using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractStack<TItem> : MonoBehaviour
{
    protected Stack<TItem> stack = new();

    public Stack<TItem> Stack => stack;

    protected abstract void Awake();

    private void OnDestroy() => stack.Clear();
}