using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject Faller;
    public float spawnWait = 2;

    public void CreateRock() 
    {
        float PosX = Random.Range(-2.7f, 2.7f);
        Vector3 Position = new Vector3(PosX, 6, 0);
        Instantiate(Faller, Position, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
    }

    void Start() 
    {
        InvokeRepeating("CreateRock", 2f, 2f);
        Debug.Log("hi");
    }


    public void Explode() 
    {
        Destroy(gameObject);
    }
}
