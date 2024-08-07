public sealed class ButtonSubmit : AbstractButton
{
    private AbstractCounter counterCorrectAnswer;

    protected override void OnEnable()
    {
        counterCorrectAnswer = GetComponentInParent<AbstractCounter>();
        base.OnEnable();
    }

    protected override void OnClick() => counterCorrectAnswer.ResetCount();
}