using System.Collections.Generic;
using TMPro;
using UnityEngine;

public sealed class ProductCanvasQuestion : MonoBehaviour, IProduct<ScriptableObjectQuestion>, IShareable<List<ScriptableObjectQuestionOption>>
{
    public List<ScriptableObjectQuestionOption> Data { get; private set; }

    public void Initialize(ScriptableObjectQuestion scriptableObjectQuestion)
    {
        transform.GetChild(index: 1).GetComponentInChildren<TextMeshProUGUI>().text = scriptableObjectQuestion.text;
        Data = scriptableObjectQuestion.optionList;
    }
}