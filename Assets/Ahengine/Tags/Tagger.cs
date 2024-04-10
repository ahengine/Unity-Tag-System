using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Tagger", menuName = "Tagger", order = 0)]
public class Tagger : ScriptableObject 
{
    [field:SerializeField] public string Tag { private set; get; }

    public bool Compare(Tagger other) => 
        other != null && other.Tag == Tag;
}
