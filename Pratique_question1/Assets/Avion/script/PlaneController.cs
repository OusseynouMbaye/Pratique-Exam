using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 700.0f;
    private Rigidbody my_rigidbody;

    // Start is called before the first frame update
    void Start()
    {

        my_rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float vitesse = Input.GetAxis("Jump");
        if (vitesse!=0)
        {

            Helice(vitesse);
        }
    }
    private void Helice(float acceleration)
    {
        my_rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime);
    }
}
