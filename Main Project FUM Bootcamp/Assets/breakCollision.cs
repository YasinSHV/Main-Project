using UnityEngine;

public class breakCollision : MonoBehaviour
{
    public GameObject breakParticle, wallParticle;
    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "Block"){
            Destroy(col.gameObject);
            Instantiate(breakParticle, col.gameObject.transform.position, Quaternion.identity);
        }
        else if (col.gameObject.tag == "Wall"){
            Instantiate(wallParticle, gameObject.transform.position, Quaternion.identity);
        }
    }
}
