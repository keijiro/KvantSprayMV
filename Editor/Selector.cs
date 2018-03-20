using UnityEditor;

namespace Kvant
{
    static class SprayMVSelector
    {
        [MenuItem("Packages/Kvant SprayMV")]
        static void OpenPackageDirectory()
        {
            var path = "Packages/jp.keijiro.kvant.spray-mv/README.md";
            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(path);
            EditorGUIUtility.PingObject(Selection.activeObject);
        }
    }
}
