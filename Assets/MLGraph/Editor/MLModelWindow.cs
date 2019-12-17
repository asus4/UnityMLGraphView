using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace MLGraph
{

    public class MLModelWindow : EditorWindow
    {
        [MenuItem("Window/ML/Model Graph")]
        public static void Open()
        {
            GetWindow<MLModelWindow>("Model Graph");
        }

        private void OnEnable()
        {
            Debug.Log("editor on enable");



            var rootView = new MLModelView()
            {
                style = { flexGrow = 1 }
            };
            rootVisualElement.Add(rootView);
        }

        private void LoadMLModel(string file)
        {
            var path = Path.Combine(Application.streamingAssetsPath, file);
            var reader = new ModelReader(path);
            Debug.Log(reader);
        }
    }


}
