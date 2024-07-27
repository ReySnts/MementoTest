using System.Threading.Tasks;
using UnityEngine;

public abstract class AbstractLayoutGroup<TProduct> : MonoBehaviour
{
    protected virtual async void Awake()
    {
        var abstractFactory = GetComponent<AbstractFactory<TProduct>>();
        var abstractList = GetComponent<AbstractList<TProduct>>();
        await Task.Delay(millisecondsDelay: TaskDelay.MILLISECOND_20FPS);
        abstractList.List.ForEach(action: product =>
        {
            if (destroyCancellationToken.IsCancellationRequested) return;
            else abstractFactory.GetProduct(product);
        });
    }
}