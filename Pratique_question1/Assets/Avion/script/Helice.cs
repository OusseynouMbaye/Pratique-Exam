using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 700.0f;
    public GameObject helice;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float vitesse = Input.GetAxis("Jump");

        helice.transform.Rotate( new Vector3 ( 0, 0, vitesse * speed * Time.deltaTime) );
    }
}
