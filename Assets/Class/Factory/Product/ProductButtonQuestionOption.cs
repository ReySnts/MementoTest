using TMPro;
using UnityEngine;

public sealed class ProductButtonQuestionOption : MonoBehaviour, IProduct<ScriptableObjectQuestionOption>, IShareable<ScriptableObjectQuestionOption>
{
    public ScriptableObjectQuestionOption Data { get; private set; }

    public void Initialize(ScriptableObjectQuestionOption scriptableObjectQuestionOption)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = scriptableObjectQuestionOption.text;
        Data = scriptableObjectQuestionOption;
    }
}