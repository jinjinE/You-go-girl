using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    float playerx;
    public float movePower1 = 0.05f;
    public float movePower2 = -0.05f;
    public bool inputLeft = false;
    public bool inputRight = false;
    public int book = 0;


    Vector3 movement;
    void Start()
    {
        butUI ui = GameObject.FindGameObjectWithTag("Player").GetComponent<butUI>();
        ui.Init();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -112.57f, 8.27f), -1.34f, 0);
        move();
    }

    void move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (inputLeft)
        {
            moveVelocity = Vector3.left;
            transform.Translate(movePower2, 0, 0);
            transform.localScale = new Vector3(-6.823271f, 6.823271f, 6.823271f);
        }
        else if (inputRight)
        {
            moveVelocity = Vector3.right;
            transform.Translate(movePower1, 0, 0);
            transform.localScale = new Vector3(6.823271f, 6.823271f, 6.823271f);
        }
    }
    public void stop()
    {

    }
}
