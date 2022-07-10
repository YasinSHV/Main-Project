using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public Transform tr;
    private float speed = 0.24f;


    void Update()
    {
        tr.position = new Vector3(tr.position.x , tr.position.y, tr.position.z - speed * Time.deltaTime);
    }


}
