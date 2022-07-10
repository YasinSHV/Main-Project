using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallMovement : MonoBehaviour
{

    public bool locked = true;
    public Transform lockPosition;
    public Rigidbody rb;
    public int startForce = -100;
    public AudioSource music;
    public GameObject player;
    public GameObject deathEffect;

    public TextMeshProUGUI LifeText;
    private int lifeCount = 3;
    private float lastZ = 0;
    private int checkZDelay = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, startForce);
    }

    private void FixedUpdate()
    {
        if (!locked){
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


            if (transform.position.z < -13f)
            {
                lifeCount--;
                LifeText.text = lifeCount.ToString();
                if (lifeCount == 0)
                {
                    Instantiate(deathEffect, player.transform.position, Quaternion.identity);
                    Time.timeScale = 0.2f;
                    music.pitch = 0.6f;
                    player.SetActive(false);
                    Destroy(this.gameObject);
                }
                else
                {
                    Instantiate(deathEffect, player.transform.position, Quaternion.identity);
                    transform.position = new Vector3(0, 0.9f,  -5.22f);
                    locked = true;
                }
            } 
        }
        else{
            gameObject.transform.position = lockPosition.position;
        }

        if (Input.GetMouseButton(0)){
            locked = false;
        }
    }
}
