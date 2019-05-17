using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SpawnScript))]
public class NewBehaviourScript : Editor
{
    public override void OnInspectorGUI()
    {
        

        //Fetch SpawnScript
        SpawnScript script = (SpawnScript)target;

        script.spawnPoint = EditorGUILayout.Vector3Field("Spawn point",script.spawnPoint);
        //Draw a button to build spheres
        if(GUILayout.Button("Build Sphere"))
        {
            script.Duplicate();
        }
    }
}
