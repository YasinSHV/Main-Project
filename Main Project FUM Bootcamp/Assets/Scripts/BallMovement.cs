using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;
    public int startForce = -100;
    public AudioSource music;
    public GameObject player;
    public GameObject deathEffect;

    public TextMeshProUGUI LifeText;
    private int lifeCount = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, startForce);
    }

    private void FixedUpdate()
    {
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
                rb.AddForce(0, 0, -(startForce/2));
                transform.position = new Vector3(0, 0.9f,  -5.22f);
            }
        } 
    }
}
