using UnityEngine;

[RequireComponent(requiredComponent: typeof(IShareable<AbstractCanvas>))]

public sealed class ButtonSubject : AbstractButton
{
    private IShareable<AbstractCanvas> iShareable;

    private AbstractContext<AbstractCanvas> canvasContext;

    protected override void OnEnable()
    {
        iShareable = GetComponent<IShareable<AbstractCanvas>>();
        canvasContext = GetComponentInParent<AbstractContext<AbstractCanvas>>();
        base.OnEnable();
    }

    protected override void OnClick() => canvasContext.SetStrategy(strategy: iShareable.Data);
}