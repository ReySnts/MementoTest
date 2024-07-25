using TMPro;
using UnityEngine;

public sealed class ProductButtonQuestionOption : MonoBehaviour, IProduct<ScriptableObjectQuestionOption>
{
    public void Initialize(ScriptableObjectQuestionOption scriptableObjectQuestionOption) => GetComponentInChildren<TextMeshProUGUI>().text = scriptableObjectQuestionOption.text;
}