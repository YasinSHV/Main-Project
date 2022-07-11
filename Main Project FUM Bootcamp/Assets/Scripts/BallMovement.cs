using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int startForce = -100;
    private float lastZ = 0;
    private int checkZDelay = 0;
    public GameObject gameOver;
    public GameObject retryButton;
    private bool looseFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, startForce);
    }

    private void FixedUpdate()
    {
        
        rb.AddForce(rb.velocity.normalized * Time.deltaTime * 5);

        if (Mathf.Abs(gameObject.transform.position.z-lastZ) < 0.1){
            checkZDelay++;
        }
        else {
            checkZDelay = 0;
        }

        if (checkZDelay > 100000*Time.deltaTime){
            rb.AddForce(0,0,-10);
        }
        lastZ = gameObject.transform.position.z;

        //Losing
        if (!looseFlag && gameObject.transform.position.z < -15){
            gameOver.SetActive(true);
            retryButton.SetActive(true);
            Time.timeScale = 0.2f;
            playerMovement.speed = 0;
            cubeMovement.speed = 0;
            looseFlag = true;
        }
    }
}
