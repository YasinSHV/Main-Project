using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public int lives = 0;
    public Transform tr;
    public static float speed = 0.24f;


        if (isLifeBlock || isBallIncrease || isFireBall || IsLaunch)
            lives = 1;
        else
        {
            lives = Random.Range(1, 1000);
            if (lives < 30 && lives > 0)
                lives = 4;
            else if (lives >= 30 && lives < 100)
                lives = 3;
            else if (lives >= 100 && lives < 350)
                lives = 2;
            else if (lives >= 350 && lives <= 1000)
                lives = 1;

            switch (lives)
            {
                case 1:
                    GetComponent<Renderer>().material = oneLife;
                    break;
                case 2:
                    GetComponent<Renderer>().material = TwoLives;
                    break;
                case 3:
                    GetComponent<Renderer>().material = ThreeLives;
                    break;
                case 4:
                    GetComponent<Renderer>().material = FourLives;
                    break;
            }
        }
    }
    void Update()
    {
        tr.position = new Vector3(tr.position.x , tr.position.y, tr.position.z - speed * Time.deltaTime);

        if (isLifeBlock || isBallIncrease || isFireBall || IsLaunch)
            Debug.Log(lives); 
        else
        switch (lives)
        {
            case 1:
                GetComponent<Renderer>().material = oneLife;
                break;
            case 2:
                GetComponent<Renderer>().material = TwoLives;
                break;
            case 3:
                GetComponent<Renderer>().material = ThreeLives;
                break;
            case 4:
                GetComponent<Renderer>().material = FourLives;
                break;
        }


    }


}
