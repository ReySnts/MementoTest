using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class ListQuestion : ListScriptableObject<ScriptableObjectQuestion>
{
    protected override string TFilePath => FilePath.QUESTION;

    protected override void Awake()
    {
        base.Awake();
        LoadAllOptions();
        Randomize();
    }

    private void LoadAllOptions() => list.ForEach(action: question =>
    {
        question.optionList = new List<ScriptableObjectQuestionOption>(collection: Resources.LoadAll<ScriptableObjectQuestionOption>(path: FilePath.SCRIPTABLE_OBJECT + FilePath.QUESTION_OPTION_SLASH + question.name));
        question.optionList.ForEach(action: option => option.text = option.name);
    });

    private void Randomize()
    {
        var random = new System.Random();
        list = list.OrderBy(keySelector: question => random.Next()).ToList();
    }

    private void ClearAllOptions() => list.ForEach(action: question =>
    {
        question.optionList.ForEach(action: option => option.text = null);
        question.optionList.Clear();
    });

    protected override void OnDestroy()
    {
        ClearAllOptions();
        base.OnDestroy();
    }
}