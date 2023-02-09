using UnityEditor;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

namespace TagSystem
{
    [CustomPropertyDrawer(typeof(TagVariable))]
    public class TagVariableEditorEditor : PropertyDrawer
    {
        private const string TagSettingsName = "TagSettings";
        private const string TagName = "Tag";

        int index = 0;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) =>
            label != GUIContent.none && Screen.width < 333 ? (16f + 18f) : 16f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            int oldIndentLevel = EditorGUI.indentLevel;
            label = EditorGUI.BeginProperty(position, label, property);
            Rect contentPosition = EditorGUI.PrefixLabel(position, label);
            if (position.height > 16f)
            {
                position.height = 16f;
                EditorGUI.indentLevel += 1;
                contentPosition = EditorGUI.IndentedRect(position);
                contentPosition.y += 18f;
            }
            contentPosition.width *= 0.5f;
            EditorGUI.indentLevel = 0;


            if (Selection.objects.Length > 1)
                return;

            var TagProp = property.FindPropertyRelative(TagName);
            TagsSettings tagsSettings = 
                EditorGUI.ObjectField(contentPosition, property.FindPropertyRelative(TagSettingsName).objectReferenceValue, typeof(TagsSettings), true) as TagsSettings;

            if (!tagsSettings)
                return;

            property.FindPropertyRelative(TagSettingsName).objectReferenceValue = tagsSettings;

            if (tagsSettings.Tags.Length == 0)
                return;

            // Between two Parameter in Editor
            contentPosition.x += contentPosition.width;
            contentPosition.width /= 1.1f;
            EditorGUIUtility.labelWidth = 30f;

            index = EditorGUI.Popup(contentPosition,
                   tagsSettings.GetIndex(TagProp.stringValue), tagsSettings.Tags);

            if (index == tagsSettings.GetIndex(TagProp.stringValue)) return;

            TagProp.stringValue = tagsSettings.Tags[index];

            EditorGUI.EndProperty();
        }
    }
}