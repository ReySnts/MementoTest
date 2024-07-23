using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class ProductButtonSubject : MonoBehaviour, IProduct<ScriptableObjectButtonSubject>, IShareable<AbstractCanvas>
{
    public AbstractCanvas Data { get; private set; }

    public void Initialize(ScriptableObjectButtonSubject scriptableObjectButtonSubject)
    {
        transform.GetChild(index: 0).GetComponent<Image>().sprite = scriptableObjectButtonSubject.sprite;
        GetComponentInChildren<TextMeshProUGUI>().text = scriptableObjectButtonSubject.text;
        Data = scriptableObjectButtonSubject.canvasSubject;
    }
}