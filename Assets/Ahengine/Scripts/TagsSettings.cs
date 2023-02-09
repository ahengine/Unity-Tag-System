using UnityEngine;

namespace TagSystem
{
    [CreateAssetMenu(fileName = "TagsSettings", menuName = "Data/TagsSettings", order = 1)]
    public class TagsSettings : ScriptableObject
    {
        [field:SerializeField] public string[] Tags { private set; get; }
        public int GetIndex(string tag)
        {
            for (int i = 0; i < Tags.Length; i++)
                if (Tags[i] == tag)
                    return i;

            return 0;
        }
    }
}