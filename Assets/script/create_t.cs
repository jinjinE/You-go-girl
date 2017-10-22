using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_t : MonoBehaviour
{
    float timet;
    int check;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject player;
    /*private static Vector3 GetRandomPos()
    {

        Vector3 randomPos = new Vector3(-1.56f, -1.99f,0);
        return randomPos;
    }*/
    void Start()
    {
        StartCoroutine(ObjectRandomGenerator());
    }


    void Update()
    {
    }

    IEnumerator ObjectRandomGenerator()
    {
        GameObject[] tempGO = new GameObject[4];

        tempGO[0] = obj1;
        tempGO[1] = obj1;
        tempGO[2] = obj2;
        tempGO[3] = obj2;

        while (true)
        {
            timet = UnityEngine.Random.Range(5f, 10f);
            check = UnityEngine.Random.Range(0, 3);
            Instantiate(tempGO[check], new Vector2(-67.77f, -1.101f), Quaternion.identity);
            yield return new WaitForSeconds(timet);
        }
    }

}
