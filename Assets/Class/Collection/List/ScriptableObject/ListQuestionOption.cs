using System.Collections.Generic;
using System.Threading.Tasks;

public sealed class ListQuestionOption : AbstractList<ScriptableObjectQuestionOption>
{
    protected override async void Awake()
    {
        await Task.Delay(millisecondsDelay: TaskDelay.MILLISECOND_20FPS);
        list = GetComponentInParent<IShareable<List<ScriptableObjectQuestionOption>>>().Data;
    }
}