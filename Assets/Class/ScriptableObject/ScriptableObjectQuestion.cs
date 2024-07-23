using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = FilePath.QUESTION, menuName = FilePath.SCRIPTABLE_OBJECT + FilePath.QUESTION)]

public sealed class ScriptableObjectQuestion : ScriptableObject
{
    [Space(height: 20f), TextArea(minLines: 1, maxLines: 20)] public string text;

    [SerializeField, Space(height: 20f)] private List<ScriptableObjectQuestionOption> optionList;

    public List<ScriptableObjectQuestionOption> OptionList => optionList;

    private void Awake()
    {
        optionList.Clear();
        optionList = new List<ScriptableObjectQuestionOption>(collection: Resources.LoadAll<ScriptableObjectQuestionOption>(path: FilePath.SCRIPTABLE_OBJECT + FilePath.QUESTION_OPTION + "/" + name));
        Debug.Log(name + " " + optionList.Count);
    }
}