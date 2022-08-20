using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager))]
public class CustomGameManager : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GameManager gameManager = (GameManager)target;
        if(GUILayout.Button("Clear Data"))
        {
            gameManager.ClearData();
        }
    }
}
