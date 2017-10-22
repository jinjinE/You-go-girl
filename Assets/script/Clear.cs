using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

	// Use this for initialization
	public void onStart () {
        SceneManager.LoadScene("start");
		
	}
	
	// Update is called once per frame
	void Update () {
    }
}
