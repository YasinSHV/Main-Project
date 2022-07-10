using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFireball : MonoBehaviour
{
    public GameObject fireball;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)){
            Instantiate(fireball, new Vector3(gameObject.transform.position.x, 10, gameObject.transform.position.z+5), Quaternion.identity);
        }
    }
}
