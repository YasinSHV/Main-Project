using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;
    public int startForce = -100;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, startForce);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
