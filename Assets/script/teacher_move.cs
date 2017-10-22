using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teacher_move : MonoBehaviour
{

    public float b = 0.1f;
    public bool check = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        transform.Translate(b, 0, 0);
    }
    public void stop() {
        for(int i = 0; i < 50; i++)
        {

        }
    }
}
