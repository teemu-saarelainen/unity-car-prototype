using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward for some amount
        //transform.Translate(0, 0, 0.25f);
        //transform.Translate(Vector3.forward*0.25f);
        transform.Translate(Vector3.forward*Time.deltaTime*speed);

    }
}
