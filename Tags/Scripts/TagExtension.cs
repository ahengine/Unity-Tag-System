using UnityEngine;

namespace TagSystem
{
    public static class TaggerExtention
    {
        public static string Tag(this Component comp)
        {
            var item = comp.GetComponent<Tagger>();

            if (!item) return null;
            Debug.Log(item.Tag);
            return item.Tag;
        }

        public static bool CompareWithThisTag(this Component comp, string tag) => Tag(comp) == tag;
        public static bool CompareWithThisTag(this Component comp, TagVariable tag) => Tag(comp) == tag.Tag;
        public static bool CompareWithThisTag(this Component comp, Tagger tag) => Tag(comp) == tag.Tag;
    }
}