using UnityEngine;

[CreateAssetMenu(menuName = FilePath.SCRIPTABLE_OBJECT + FilePath.BUTTON_SUBJECT)]

public sealed class ScriptableObjectButtonSubject : ScriptableObject
{
    [Space(height: 20f)] public Sprite sprite;

    [Space(height: 20f)] public string text;

    [Space(height: 20f)] public CanvasSubject canvasSubject;
}