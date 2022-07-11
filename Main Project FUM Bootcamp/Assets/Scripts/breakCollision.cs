using UnityEngine;
using TMPro;
public class breakCollision : MonoBehaviour
{
    public GameObject breakParticle, wallParticle;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private Rigidbody rb;
/*    private Vector3 endingPos;*/

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        Vector3 startingPos = transform.position;
        if (col.gameObject.tag == "Block")
        {
            score += 1;
            scoreText.text = score.ToString();
            col.gameObject.GetComponent<cubeMovement>().ChangeLife();
            if (col.gameObject.GetComponent<cubeMovement>().lives == 0) 
            {
            Destroy(col.gameObject);
            }
            Instantiate(breakParticle, col.gameObject.transform.position, Quaternion.identity);
/*            if (startingPos.z > endingPos.z)
             rb.AddForce(0, 0, 40);
            else
             rb.AddForce(0, 0, -40);*/
        }
        else if (col.gameObject.tag == "Wall")
        {
            Instantiate(wallParticle, gameObject.transform.position, Quaternion.identity);
        }
/*        endingPos = transform.position;*/
    }
}
