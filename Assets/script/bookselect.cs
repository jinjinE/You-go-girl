using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookselect : MonoBehaviour {
    public playermovement player;
    public GameObject math, korea, java;
    public new Collider2D Player_ani;
    Animator play;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("PlayerM").GetComponent<playermovement>();
        play = Player_ani.GetComponent<Animator>();
    }
    public void Math()
    {
        player.book = 1;
        play.SetBool("check_2", true);
        Destroy(math);
        Destroy(java);
        Destroy(korea);
    }
    public void Korea()
    {
        player.book = 2;
        play.SetBool("check_2", true);
        Destroy(math);
        Destroy(java);
        Destroy(korea);
    }
    public void Java()
    {
        player.book = 3;
        play.SetBool("check_2", true);
        Destroy(math);
        Destroy(java);
        Destroy(korea);
    }
}
