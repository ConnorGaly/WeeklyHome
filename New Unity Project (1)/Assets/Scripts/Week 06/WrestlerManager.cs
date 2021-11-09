using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrestlerManager : MonoBehaviour
{
    public List<string> firstNames = new List<string>();
    public List<string> lastNames = new List<string>();
    public List<string> wrestlerNames = new List<string>() { "Spider-Man", "Venom", "Handsome Cop", "Waifu", "The Hair" };

    public List<Wrestler> allWrestlers = new List<Wrestler>();

    // Start is called before the first frame update
    void Start()
    {
        lastNames.Add("Parker");
        lastNames.Add("Brock");
        lastNames.Add("S.Kennedy");
        lastNames.Add("Redfield");
        lastNames.Add("Harrington");

        //loop through all my wrestlers and assign a random name!!
        for (int i = 0; i < allWrestlers.Count; i++)
        {
            allWrestlers[i].firstName = firstNames[Random.Range(0,firstNames.Count)];
            allWrestlers[i].lastName = lastNames[Random.Range(0, lastNames.Count)];
            allWrestlers[i].wrestlerName = wrestlerNames[Random.Range(0, wrestlerNames.Count)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
