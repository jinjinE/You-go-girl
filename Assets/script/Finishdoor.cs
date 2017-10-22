using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishdoor : MonoBehaviour {

    public new Collider2D collider2D;
    public playermovement player;
    public GameObject camera;
    public GameObject clear;
    public GameObject lose;
    public GameObject time;
    time timecheck;
    public bool clearcheck = false;

    // Use this for initialization
    void Start () {
        timecheck = time.GetComponent<time>();
        player = GameObject.Find("PlayerM").GetComponent<playermovement>();

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
                    if (collider2D.tag == "Finish" && timecheck.check && player.book == 3)
                    {
                        clear.transform.position = new Vector3(camera.transform.position.x + 1300f, camera.transform.position.y + 700f, camera.transform.position.z);
                        clearcheck = true;
                    }
                    else
                    {
                        lose.transform.position = new Vector3(camera.transform.position.x + 1300f, camera.transform.position.y + 700f, camera.transform.position.z);
                        clearcheck = true;
                    }
                }
            }
        }
    }
}
