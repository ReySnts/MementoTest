using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class ButtonSubject : MonoBehaviour, IProduct<ScriptableObjectButtonSubject>
{
    public void Initialize(ScriptableObjectButtonSubject scriptableObjectButtonSubject)
    {
        transform.GetChild(index: 0).GetComponent<Image>().sprite = scriptableObjectButtonSubject.sprite;
        GetComponentInChildren<TextMeshProUGUI>().text = scriptableObjectButtonSubject.text;
    }
}