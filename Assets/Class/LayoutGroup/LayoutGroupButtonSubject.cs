using UnityEngine;

[RequireComponent(typeof(FactoryButtonSubject), typeof(ListButtonSubject))]

public sealed class LayoutGroupButtonSubject : AbstractLayoutGroup<ScriptableObjectButtonSubject> { }