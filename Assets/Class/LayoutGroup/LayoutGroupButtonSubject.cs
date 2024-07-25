using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractFactory<ScriptableObjectButtonSubject>), requiredComponent2: typeof(AbstractList<ScriptableObjectButtonSubject>))]

public sealed class LayoutGroupButtonSubject : AbstractLayoutGroup<ScriptableObjectButtonSubject> { }