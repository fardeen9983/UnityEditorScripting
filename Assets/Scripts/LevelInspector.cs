using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInspector : MonoBehaviour
{
    //Visible in the inspector
    [Range(0,1000000000)]
    public int experience;
    //Property not visible in the inspector
    public int Level
    {
        get { return experience / 500; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
