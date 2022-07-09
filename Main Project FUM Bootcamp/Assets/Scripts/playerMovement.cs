using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int speed = 4000;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a") && player.position.x > -5.3){
            player.position = new Vector3(player.position.x - speed*Time.deltaTime, player.position.y, player.position.z);
        }

        if (Input.GetKey("d") && player.position.x < 7.9){
            player.position = new Vector3(player.position.x + speed*Time.deltaTime, player.position.y, player.position.z);
        }
    }
}
