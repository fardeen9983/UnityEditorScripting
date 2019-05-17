using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//Specify the script we are customizing as an attribute
[CustomEditor(typeof(LevelInspector))]
public class LevelScriptEditor : Editor
{
    //Override OnInspectGUI mehtod which is called everytime the inspector GUI is drawn
    public override void OnInspectorGUI()
    {
        //Omitting this line will make inspector GUI void of any previous information making it useless
        //Draws the Basic Inspector GUI
        //base.OnInspectorGUI();

        //Get access to LevelInspector object
        LevelInspector levelScript = (LevelInspector)target;

        //Information to be shown : Experience and level
        //Create two integers fields for this using EditorGUILayout
        //Proveide name value pairs for all fields
        //Also allow modification to field values from the editor
        levelScript.experience = EditorGUILayout.IntField("Experience",levelScript.experience);
        //Display level field as read-only
        EditorGUILayout.LabelField("Level", levelScript.Level.ToString());

    }
}
