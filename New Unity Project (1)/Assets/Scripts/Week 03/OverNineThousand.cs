using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverNineThousand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerOne = PowerLevel(2, 3, 4);
        int playerTwo = PowerLevel(3, 4, 5);
        Debug.Log(playerOne + " " + playerTwo);
        ComparePowers(playerOne, playerTwo); //call my compare power level
    }

    private void ComparePowers(int playerOne, int playerTwo)
    {
        if(playerOne > playerTwo)
        {
            float percentage = (int) (((float) playerTwo/ (float) playerOne) * 100);
            //do a lil dance
            Debug.Log("The winner is player one, they had " + playerOne +
                " power level and player two had " + playerTwo + " power level"
                + "The winner won by " + percentage + "percemt");
        }
        else if(playerTwo > playerOne)
        {
            //do another lil dance
            float percentage = (int) (((float) playerOne / (float) playerTwo) * 100);
            //do a lil dance
            Debug.Log("The winner is player two, they had " + playerTwo +
                " power level and player one had " + playerOne + " power level"
                + "The winner won by " + percentage + "percemt");
        }
        else
        {
            //dey da same
            Debug.Log("Draw :)");
        }

    }




    private int PowerLevel(int str, int agil, int intel)
    {
        int power = (int) ((str * 2) + (agil * 1.5f) + intel);
        return power;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
