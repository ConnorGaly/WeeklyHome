using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject capsulePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(capsulePrefab,new Vector3(1,1,1),Quaternion.identity);
        Instantiate(capsulePrefab, new Vector3(7, 2, 7), Quaternion.identity);
        Instantiate(capsulePrefab, new Vector3(4, 2, 0), Quaternion.identity);
        Instantiate(capsulePrefab, new Vector3(9, 8, 1), Quaternion.identity);
        Instantiate(capsulePrefab, new Vector3(15, 12, 10), Quaternion.identity);
        // Instantiate(capsulePrefab, new Vector3(2, 1, 1), transform.rotation);
        //Instantiate(capsulePrefab, new Vector3(3, 1, 1), Quaternion.EulerAngle(0,90,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
