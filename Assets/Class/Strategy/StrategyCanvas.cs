using UnityEngine;

public sealed class StrategyCanvas : MonoBehaviour, IStrategy<AbstractCanvas>
{
    public void SetStrategy(AbstractCanvas abstractCanvas)
    {
        Destroy(obj: transform.GetChild(index: 0).gameObject);
        Instantiate(original: abstractCanvas, parent: transform);
    }
}
