using System.Collections.Generic;

public sealed class ListQuestionOption : AbstractList<ScriptableObjectQuestionOption>
{
    protected override void Awake() => list = GetComponentInParent<IShareable<List<ScriptableObjectQuestionOption>>>().Data;
}