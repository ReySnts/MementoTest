using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractList<ScriptableObjectQuestion>), requiredComponent2: typeof(AbstractFactory<ScriptableObjectQuestion>), requiredComponent3: typeof(AbstractContext<ScriptableObjectQuestion>))]

public sealed class StackQuestionSequence : AbstractStack<ScriptableObjectQuestion>, ICommander
{
    private AbstractFactory<ScriptableObjectQuestion> questionFactory;

    private AbstractList<ScriptableObjectQuestion> questions;

    private AbstractContext<ScriptableObjectQuestion> questionContext;

    private readonly int zero = 0;

    protected override async void Awake()
    {
        questionFactory = GetComponent<AbstractFactory<ScriptableObjectQuestion>>();
        questions = GetComponent<AbstractList<ScriptableObjectQuestion>>();
        questionContext = GetComponent<AbstractContext<ScriptableObjectQuestion>>();
        await Task.Delay(millisecondsDelay: TaskDelay.MILLISECOND_20FPS);
        RedoCommand();
    }

    public void RedoCommand()
    {
        if (questions.List.Count > zero)
        {
            var currentFirstListQuestion = questions.List[index: zero];
            questionContext.SetStrategy(strategy: currentFirstListQuestion);
            questionFactory.GetProduct(product: currentFirstListQuestion);
            stack.Push(item: currentFirstListQuestion);
            questions.List.RemoveAt(index: zero);
        }
    }

    public void UndoCommand()
    {
        if (stack.Count > 1)
        {
            questions.List.Insert(index: zero, item: stack.Pop());
            var currentStackPeekQuestion = stack.Peek();
            questionContext.SetStrategy(strategy: currentStackPeekQuestion);
            questionFactory.GetProduct(product: currentStackPeekQuestion);
        }
    }
}