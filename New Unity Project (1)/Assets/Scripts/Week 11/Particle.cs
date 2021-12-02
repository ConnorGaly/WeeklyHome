using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem fire;
    public ParticleSystem[] allParticleEffects;
    public List<ParticleSystem> particleList = new List<ParticleSystem>();

    // Start is called before the first frame update
    private void Start()
    {
        particleList.AddRange(fire.GetComponentsInChildren<ParticleSystem>());
    }
    private void EnableEffect(bool enabled)
    {
        for(int i = 0; i < allParticleEffects.Length; i++)
        {
            if(enabled == false)
            {
                allParticleEffects[i].Stop();
            }
            else
            {
                allParticleEffects[i].Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        EnableEffect(true);
    }

    private void OnTriggerExit(Collider other)
    {
        EnableEffect(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
