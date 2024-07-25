using UnityEngine;

[CreateAssetMenu(fileName = FilePath.QUESTION_OPTION, menuName = FilePath.SCRIPTABLE_OBJECT + FilePath.QUESTION_OPTION)]

public sealed class ScriptableObjectQuestionOption : ScriptableObject
{
    [Space(height: 20f)] public string text;

    [Space(height: 20f)] public bool isTrue;
}