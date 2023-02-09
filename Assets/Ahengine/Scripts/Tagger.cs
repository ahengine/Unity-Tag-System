using UnityEngine;

namespace TagSystem
{
    public class Tagger : MonoBehaviour
    {
        [field: SerializeField] public TagsSettings TagSettings { private set; get; } 
        public string Tag { set; get; }

        public bool CompareWithThisTag(string tag) => Tag == tag;
        public bool CompareWithThisTag(TagVariable tag) => Tag == tag.Tag;
        public bool CompareWithThisTag(Tagger tag) => Tag == tag.Tag;
    }
}