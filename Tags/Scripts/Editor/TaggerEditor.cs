using UnityEditor;

namespace TagSystem
{
    [CustomEditor(typeof(Tagger))]
    public class TaggerEditor : Editor
    {
        int index = 0;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            var owner = target as Tagger;
            if (!owner.TagSettings || owner.TagSettings.Tags.Length == 0) return;
            index = EditorGUILayout.Popup("Tag",index, owner.TagSettings.Tags);
            if (index == owner.TagSettings.GetIndex(owner.Tag) && owner.Tag != null) return;
            owner.SetTag(owner.TagSettings.Tags[index]);
            EditorUtility.SetDirty(target);
        }
    }
}