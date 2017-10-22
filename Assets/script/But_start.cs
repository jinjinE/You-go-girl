using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class But_start : MonoBehaviour {

	// Use this for initialization
	public void Onstart()
    {
        SceneManager.LoadScene("game");
    }
	
	// Update is called once per frame
	public void Onmethod() {
        SceneManager.LoadScene("method");
	}
}
