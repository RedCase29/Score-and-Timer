using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public float currentTime = 30f;

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        TimerText.text = "Time: " + (int)currentTime + " seconds";
        if(currentTime <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
