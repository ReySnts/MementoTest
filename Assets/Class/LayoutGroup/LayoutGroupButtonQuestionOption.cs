using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractFactory<ScriptableObjectQuestionOption>), requiredComponent2: typeof(AbstractList<ScriptableObjectQuestionOption>))]

public sealed class LayoutGroupButtonQuestionOption : AbstractLayoutGroup<ScriptableObjectQuestionOption> { }