using UnityEngine;

[CreateAssetMenu(fileName = FilePath.QUESTION_OPTION, menuName = FilePath.SCRIPTABLE_OBJECT + FilePath.QUESTION_OPTION)]

public sealed class ScriptableObjectQuestionOption : ScriptableObject
{
    [SerializeField, Space(height: 20f)] private string text;

    public string Text => text;

    [Space(height: 20f)] public bool isTrue;

    private void Awake() => text = name;
}