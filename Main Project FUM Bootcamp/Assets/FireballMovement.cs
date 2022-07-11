using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour
{
    public GameObject impactParticle;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y-0.2f, gameObject.transform.position.z);
    }

    void OnCollisionEnter(Collision col){
        Instantiate(impactParticle, transform.position, Quaternion.identity);
    }


}
