using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butUI : MonoBehaviour
{

    GameObject player;
    playermovement playerscript;

    // Use this for initialization
    public void Init()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerscript = player.GetComponent<playermovement>();
    }

    // Update is called once per frame
    public void LeftDown()
    {
        playerscript.inputLeft = true;
    }
    public void LeftUp()
    {
        playerscript.inputLeft = false;
    }
    public void RightDown()
    {
        playerscript.inputRight = true;
    }
    public void RightUp()
    {
        playerscript.inputRight = false;
    }
}

