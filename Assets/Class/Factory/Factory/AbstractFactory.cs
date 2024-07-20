using UnityEngine;

public abstract class AbstractFactory<TProduct> : MonoBehaviour
{
    [SerializeField] private GameObject original;

    public IProduct<TProduct> GetProduct(TProduct product)
    {
        var instance = Instantiate(original, parent: transform);
        var newProduct = instance.GetComponent<IProduct<TProduct>>();
        newProduct.Initialize(product);
        return newProduct;
    }
}