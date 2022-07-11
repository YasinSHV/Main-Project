using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onRetryClicked(){
        Debug.Log("Retry Clicked");
        playerMovement.speed = 15;
        cubeMovement.speed = 0.1f;
        ScoreCanvas.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
