using UnityEngine;

namespace TagSystem
{
    public static class TaggerExtention
    {
        public static bool CompareWithThisTag(this Component comp, string tag)
        {
            var item = comp.GetComponent<Tagger>();

            if (!item) return false;

            return item.CompareWithThisTag(tag);
        }

        public static bool CompareWithThisTag(this Component comp, TagVariable tag)
        {
            var item = comp.GetComponent<Tagger>();

            if (!item) return false;

            return item.CompareWithThisTag(tag);
        }

        public static bool CompareWithThisTag(this Component comp, Tagger tag)
        {
            var item = comp.GetComponent<Tagger>();

            if (!item) return false;

            return item.CompareWithThisTag(tag);
        }
    }
}