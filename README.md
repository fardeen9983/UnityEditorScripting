# UnityEditorScripting
## Extending the inspector
We can extend the editor to create a custom inspector where we decide which infomation is to be shown.

To do this we create C# classes extending Editor class rather than MonoBehaviour and place them in Assets > Editor folder necessarily.

To use Editor class import the namespace UnityEditor

Also we need to specify the script that we are customizing through this editor as an attribute
```c#
[CustomEditor(typeof(ScriptClass))]
using UnityEditor;
public class CustomEditor : Editor
{
    //........
}
```

To create the custom editor we override the onInspectorGUI mehtod

We have an implicit object refering to the script in our editor by the name of ' target ' but first needs to be cast to proper class

Various fields :
1. Vector3 field
2. HelpBox
3. LabelField
4. IntField
5. FloatField

Message Types:
1. Error
2. Info
3. None 
4. Warning



We can create the default inspector GUI in our custom inspector using either
```c#
public override void onInspectorGUI()
{
    base.onInspectorGUI();
    //OR
    DrawDefaultInspector();
}
```