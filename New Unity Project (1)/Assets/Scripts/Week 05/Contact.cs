using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    public string myName = "Connor";//Holds my name
    public string myNumber = "0467871842"; //holds my number
    public string myAddress = "125 Colchester Street";//Holds my address
    public string myEmail = "galyconnor@gmail.com";//holds my email address
    public string myPreferredName = "Danny Devito";//holds my preferred name

    // Start is called before the first frame update
    void Start()
    {
        //Setup();//call setup
    }

    public void Setup()
    {
        int randomNum = Random.Range(0, 4);
        if(randomNum == 0)
        {
            myName = "Peter Parker";
            myNumber = "2021";
            myAddress = "Queens";
            myEmail = "SpiderParker@gmail.com";
            myPreferredName = "Spider-Man";

        }
        if(randomNum == 1)
        {
            myName = "Eddie Brock";
            myNumber = "6969";
            myAddress = "San Francisco";
            myEmail = "SymbioteLove@gmail.com";
            myPreferredName = "Venom";
        }
        if(randomNum == 2)
        {
            myName = "Nemesis";
            myNumber = "7827";
            myAddress = "Raccoon City";
            myEmail = "ChaseJill@gmail.com";
            myPreferredName = "STAAAARS";
        }
        if(randomNum == 3)
        {
            myName = "The Executioner";
            myNumber = "1234";
            myAddress = "Silent Hill";
            myEmail = "BigSwordAndAss@gmail.com";
            myPreferredName = "Pyramid Head";
        }
    }
}
