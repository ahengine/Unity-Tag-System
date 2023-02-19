using UnityEngine;

namespace TagSystem
{
    [System.Serializable]
    public class TagVariable
    {
        public TagsSettings TagSettings;
        public string Tag;

        public bool CompareWithThisTag(string tag) => Tag == tag;
    }
}