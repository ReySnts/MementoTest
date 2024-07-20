using UnityEngine;

public abstract class AbstractLayoutGroup<TProduct> : MonoBehaviour
{
    private void Awake()
    {
        var abstractFactory = GetComponent<AbstractFactory<TProduct>>();
        var abstractList = GetComponent<AbstractList<TProduct>>();
        abstractList.List.ForEach(product => abstractFactory.GetProduct(product));
    }
}