using System.Linq;
using UnityEngine;

public abstract class ListScriptableObject<TScriptableObject> : AbstractList<TScriptableObject> where TScriptableObject : ScriptableObject
{
    protected abstract string TFilePath { get; }

    protected override void Awake() => list = Resources.LoadAll<TScriptableObject>(path: FilePath.SCRIPTABLE_OBJECT + TFilePath).ToList();
}