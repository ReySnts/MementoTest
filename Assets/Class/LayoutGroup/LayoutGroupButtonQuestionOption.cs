using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractFactory<ScriptableObjectQuestionOption>), requiredComponent2: typeof(AbstractList<ScriptableObjectQuestionOption>))]

public sealed class LayoutGroupButtonQuestionOption : AbstractLayoutGroup<ScriptableObjectQuestionOption>
{
    protected override async void Awake()
    {
        await Task.Delay(millisecondsDelay: TaskDelay.MILLISECOND_20FPS);
        base.Awake();
    }
}