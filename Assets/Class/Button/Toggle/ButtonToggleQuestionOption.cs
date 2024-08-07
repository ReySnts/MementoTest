using UnityEngine;

[RequireComponent(requiredComponent: typeof(IShareable<ScriptableObjectQuestionOption>))]

public sealed class ButtonToggleQuestionOption : AbstractButtonToggle
{
    private IShareable<ScriptableObjectQuestionOption> iShareable;

    private AbstractCounter counterCorrectAnswer;

    protected override void OnEnable()
    {
        iShareable = GetComponent<IShareable<ScriptableObjectQuestionOption>>();
        counterCorrectAnswer = GetComponentInParent<AbstractCounter>();
        base.OnEnable();
    }

    protected override void OnClick()
    {
        if (iShareable.Data.isTrue) counterCorrectAnswer.Count += isActive ? -1 : +1;
        else counterCorrectAnswer.Count += isActive ? +1 : -1;
        base.OnClick();
    }
}