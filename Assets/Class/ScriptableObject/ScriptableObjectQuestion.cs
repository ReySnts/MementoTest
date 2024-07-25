using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = FilePath.QUESTION, menuName = FilePath.SCRIPTABLE_OBJECT + FilePath.QUESTION)]

public sealed class ScriptableObjectQuestion : ScriptableObject
{
    [Space(height: 20f), TextArea(minLines: 1, maxLines: 20)] public string text;

    [Space(height: 20f)] public List<ScriptableObjectQuestionOption> optionList = new();
}