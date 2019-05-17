using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnScript : MonoBehaviour
{
    GameObject player;
    public Vector3 spawnPoint;
    public GameObject sphere;

    private void Start()
    {
        sphere = GameObject.FindWithTag("Finish");
        sphere.transform.localScale = new Vector3(5, 5, 5);
        player = GameObject.FindWithTag("Player");
        spawnPoint =  new Vector3(5, 5, 0);
    }
    public void Duplicate()
    {   //Create new instances of sphere when Build sphere is clicked in inspector
        GameObject obj = Instantiate(sphere, spawnPoint,Quaternion.identity);
        Destroy(obj, 5f);
    }
}
