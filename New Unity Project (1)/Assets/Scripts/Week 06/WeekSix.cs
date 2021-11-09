using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekSix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //for(int i =0; i < 11; i++);
        //{
        //    Debug.Log( i );
        //}
        PrintNumbersToX(1, 10);
        PrintOddNumbersToX(1, 10);
    }

    private void PrintNumbersToX(int min, int max)
    {
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            Debug.Log(i);
            sum += i;
        }
        Debug.Log(sum);
    }

    private void PrintOddNumbersToX(int min, int max)
    {
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 >= 1)
            {
                Debug.Log(i);
                sum += i;
            }
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
