using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    public Text startText;
    public Text winTeamA;
    public Text winTeamB;
    public GameObject timeA;
    public GameObject timeB;

    private float timer = 2.5f;
    private float end = 2.5f;


    void Start()
    {
        startText.gameObject.SetActive(true);
        winTeamA.gameObject.SetActive(false);
        winTeamB.gameObject.SetActive(false);
    }

    private void Update()
    {
        timer = Mathf.Clamp(timer - Time.deltaTime, 0, 100);
        if (timer == 0)
        {
            startText.gameObject.SetActive(false);
        }

        if (timeA.transform.childCount == 0 || timeB.transform.childCount == 0)
        {
            if (timeA.transform.childCount == 0) winTeamB.gameObject.SetActive(true);
            else if (timeB.transform.childCount == 0) winTeamA.gameObject.SetActive(true);

            end = Mathf.Clamp(end - Time.deltaTime, 0, 100);
            if (end == 0 && timeA.transform.childCount == 0) SceneManager.LoadScene("Lose");
            if (end == 0 && timeB.transform.childCount == 0) SceneManager.LoadScene("Win");
        }



        /*if ( (winA < 2 || winB < 2) && (timeA.transform.childCount == 0 || timeB.transform.childCount == 0) )
        {
            SceneManager.LoadScene("IPJ");
        }
        else
        {
            if (winA == 2) winTeamA.gameObject.SetActive(true);
            else if (winB == 2) winTeamB.gameObject.SetActive(true);
        }*/
    }
}
