using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    public int minute;
    public int second;
    public GameObject lose;
    public GameObject camera;  //A라는 GameObject변수 선언
    public Finishdoor finishdoor;
    int mil;
    public bool check;
    // Use this for initialization
    void Start()
    {
        minute = 9;
        second = 59;
        mil = 10;
        check = true;
        finishdoor = GameObject.Find("finish").GetComponent<Finishdoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (minute == 0 && second == 0)
        {
            check = false;
            lose.transform.position = new Vector3(camera.transform.position.x+1300f, camera.transform.position.y + 700f, camera.transform.position.z);
        }
        else if (minute <= 9 && second <= 59 &&finishdoor.clearcheck == false)
        {
            timecount();
        }
    }
    void timecount()
    {

        minute = Mathf.Clamp(minute, 0, 9);
        second = Mathf.Clamp(second, 0, 59);
        mil--;
        if (mil < 0)
        {
            second--;
            mil = 10;
            if (second < 0)
            {
                if (minute == 0)
                {
                    second = 0;
                }
                else
                {
                    second = 59;
                    minute--;
                }
            }
        }
        Text uiText = GetComponent<Text>();
        uiText.text = "Time : " + minute + " : " + second;
    }
}