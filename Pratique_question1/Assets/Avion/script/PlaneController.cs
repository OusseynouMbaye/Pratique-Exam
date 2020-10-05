using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 700.0f;
    public float decolle = 200.0f;
    private Rigidbody my_rigidbody;
    public ParticleSystem m_fumee;
    // Start is called before the first frame update
    void Start()
    {

        my_rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float vitesse = Input.GetAxis("Jump");
        float boost = Input.GetAxis("Vertical");
        if (vitesse!=0)
        {

            Helice(vitesse);
        }

        if (boost != 0) {
            my_rigidbody.AddForce(Vector3.up * decolle * Time.deltaTime);

            if (m_fumee.isStopped && !m_fumee.isPlaying)
            {
                m_fumee.Play();
            }

        }else
        {
            if ( m_fumee.isPlaying)
            {
                m_fumee.Stop();
            }
        }

    }
    private void Helice(float acceleration)
    {
        my_rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime);
    }
}
/*
   if (m_Smoke.isStopped && !m_Smoke.isPlaying)
        {
            m_Smoke.Play();
        }
        */
