using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    public float timeLimit = 87f;
    public bool timeGo = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Can Use Modulos to determine the minutes
    void Update()
    {
        if (timeGo)
        {
            timer += Time.deltaTime;
        }
        if (timer >= timeLimit)
        {
            
            timer = 0f;
            Debug.Log("Time Limit Reached!");
        }
        else
        {
            int mins = (int)(timer / 60f);
            int seconds = (int)(timer % 60);
            string message = mins + "m " + seconds + "s";
            Printer.printEvent?.Invoke(message);
            //Debug.Log(mins + "m " + seconds + "s");
            //PrintedMessage = true;
        }

    }
}
