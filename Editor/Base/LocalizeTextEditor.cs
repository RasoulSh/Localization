#if UNITY_EDITOR
using Localization.Base;
using UnityEditor;
using UnityEditor.UI;

namespace Localization.Tests.Editor.Base
{
    [CustomEditor(typeof(LocalizeLegacyText))]
    public class LocalizeTextEditor : TextEditor
    {
        public override void OnInspectorGUI()
        {
            LocalizeLegacyText component = (LocalizeLegacyText)target;
            var currLocalizationKey = component.LocalizationKey;
            var currDontChangeAlignment = component.DontChangeAlignment;
            var newLocalizationKey = (string)EditorGUILayout.TextField("Localization Key", component.LocalizationKey);
            var newDontChangeAlignment = (bool)EditorGUILayout.Toggle("Dont Change Alignment", component.DontChangeAlignment);
            if (newLocalizationKey != currLocalizationKey)
            {
                component.LocalizationKey = newLocalizationKey;
                EditorUtility.SetDirty(target);
            }
            if (newDontChangeAlignment != currDontChangeAlignment)
            {
                component.DontChangeAlignment = newDontChangeAlignment;
                EditorUtility.SetDirty(target);
            }
            base.OnInspectorGUI();
        }
    }
}
#endif