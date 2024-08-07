public sealed class ButtonQuestionNext : AbstractButton
{
    private ICommander iCommander;

    protected override void OnEnable()
    {
        iCommander = GetComponentInParent<ICommander>();
        base.OnEnable();
    }

    protected override void OnClick() => iCommander.RedoCommand();
}