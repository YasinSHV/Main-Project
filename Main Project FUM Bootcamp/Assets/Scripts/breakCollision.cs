using UnityEngine;


public class breakCollision : MonoBehaviour
{
    public GameObject breakParticle, wallParticle;
    public Rigidbody rb;
    void OnCollisionEnter(Collision col)
    {
        Vector3 startingPos = transform.position;
        if (col.gameObject.tag == "Block")
        {
            Destroy(col.gameObject, 0.1f);
            Instantiate(breakParticle, col.gameObject.transform.position, Quaternion.identity);
            ScoreCanvas.score++;
            rb.velocity = Vector3.Reflect(rb.velocity.normalized,  col.contacts[0].normal);
            rb.AddForce(rb.velocity.normalized * Time.deltaTime * 50);
        }
        else if (col.gameObject.tag == "Wall")
        {
            Instantiate(wallParticle, gameObject.transform.position, Quaternion.identity);
        }
/*        endingPos = transform.position;*/
    }
}
