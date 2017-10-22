using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class touch : MonoBehaviour {
    public new Collider2D collider2D;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            Vector3 ray;

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                ray = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(ray.x, ray.y);

                if (collider2D == Physics2D.OverlapPoint(touchPos))
                {
                    if (collider2D.tag == "Player")
                    {
                        SceneManager.LoadScene("game");
                    }
                }
            }
        }
    }
}
