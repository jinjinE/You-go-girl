using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Touch_G : MonoBehaviour
{
    Animator animator_t, animator_p;
    public new Collider2D Player;
    float playerx;
    float col_1x;
    bool check;
    time t;

    // Use this for initialization
    void Start()
    {
        animator_t = this.GetComponent<Animator>();
        animator_p = Player.GetComponent<Animator>();
        t = GameObject.Find("Text").GetComponent<time>();
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerx = Player.transform.position.x;
        col_1x = this.gameObject.transform.position.x;
       if ((playerx - 6.0f <= col_1x && playerx >= col_1x))
           {
            if (Input.touchCount >= 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {

                        if (this.gameObject.tag == "teacher")
                        {
                            check = true;
                        animator_p.SetBool("check_1", false);
                        animator_t.SetBool("check", false);
                        }
                }
            }
       }
        else if(playerx < col_1x)
        {
            if (check == false)
            {
                check = true;
                t.second -= 20;
            }
            animator_p.SetBool("check_1", true);
        }
    }
}
