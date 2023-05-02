using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    private GameManagerX gmx;
    public int pointValue;
    public ParticleSystem explosionParticle;


    void Start()
    {
       
    }
    private void OnMouseDown()
    {
        if (gmx.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gmx.UpdateScore(pointValue);
        }
       
    }

}