using UnityEngine;

[RequireComponent(requiredComponent: typeof(ICommander), requiredComponent2: typeof(AbstractContext<ScriptableObjectQuestion>))]

public sealed class CounterCorrectAnswer : AbstractCounter
{
    private ICommander iCommander;

    private AbstractContext<ScriptableObjectQuestion> questionContext;

    private void Awake()
    {
        iCommander = GetComponent<ICommander>();
        questionContext = GetComponent<AbstractContext<ScriptableObjectQuestion>>();
    }

    public override void ResetCount()
    {
        if (count == questionContext.Strategy.totalCorrectAnswers)
        {
            iCommander.RedoCommand();
            count = 0;
        }
    }
}