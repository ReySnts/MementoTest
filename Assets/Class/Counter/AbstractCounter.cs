using UnityEngine;

public abstract class AbstractCounter : MonoBehaviour
{
    [SerializeField] protected int count;

    public int Count { get => count; set => count = value; }

    public abstract void ResetCount();
}