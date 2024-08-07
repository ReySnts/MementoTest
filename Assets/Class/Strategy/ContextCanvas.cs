public sealed class ContextCanvas : AbstractContext<AbstractCanvas>
{
    public override void SetStrategy(AbstractCanvas abstractCanvas)
    {
        if (transform.childCount > 0) Destroy(obj: transform.GetChild(index: 0).gameObject);
        base.SetStrategy(strategy: abstractCanvas);
        Instantiate(original: strategy, parent: transform);
    }
}