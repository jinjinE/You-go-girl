using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classdoor : MonoBehaviour
{
    public new Collider2D collider2D;
    public GameObject math, korea, java, camera;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount == 1)
        {
            Vector3 ray;

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                ray = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(ray.x, ray.y);

                if (collider2D == Physics2D.OverlapPoint(touchPos))
                {
                    if (collider2D.tag == "Classdoor")
                    {
                        korea.transform.position = new Vector3(camera.transform.position.x + 600f, camera.transform.position.y + 800f, camera.transform.position.z);
                        java.transform.position = new Vector3(camera.transform.position.x + 1400f, camera.transform.position.y + 800f, camera.transform.position.z);
                        math.transform.position = new Vector3(camera.transform.position.x + 2200f, camera.transform.position.y + 800f, camera.transform.position.z);
                    }
                }
            }
        }

    }
}
