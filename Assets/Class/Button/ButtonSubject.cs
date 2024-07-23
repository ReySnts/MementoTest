using UnityEngine;

[RequireComponent(requiredComponent: typeof(IShareable<AbstractCanvas>))]

public sealed class ButtonSubject : AbstractButton
{
    private IShareable<AbstractCanvas> iShareable;

    private IStrategy<AbstractCanvas> iStrategy;

    protected override void OnEnable()
    {
        iShareable = GetComponent<IShareable<AbstractCanvas>>();
        iStrategy = GetComponentInParent<IStrategy<AbstractCanvas>>();
        base.OnEnable();
    }

    protected override void OnClick() => iStrategy.SetStrategy(strategy: iShareable.Data);
}