public sealed class ContextQuestion : AbstractContext<ScriptableObjectQuestion>
{
    public override void SetStrategy(ScriptableObjectQuestion scriptableObjectQuestion)
    {
        if (transform.childCount > 0) Destroy(obj: transform.GetChild(index: 0).gameObject);
        base.SetStrategy(strategy: scriptableObjectQuestion);
    }
}