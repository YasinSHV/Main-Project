using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public static int speed = 15;
    public Transform player;
    public float max_acceleration = 1;

    public float current_acceleration = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a") && current_acceleration >= -max_acceleration)
        {
            current_acceleration -= 0.05f;
        }

        if (Input.GetKey("d") && current_acceleration <= max_acceleration)
        {
            current_acceleration += 0.05f;
        }

        else if (current_acceleration > 0) current_acceleration -= 0.05f;
        else if (current_acceleration < 0 && !Input.GetKey("a")) current_acceleration += 0.05f;
        if (current_acceleration > -0.05 && current_acceleration < 0.05) current_acceleration = 0;

        if ((current_acceleration < 0 && player.position.x < -6.8) || (current_acceleration > 0 && player.position.x > 5))
        {
            current_acceleration = 0;
        }
        player.position = new Vector3(player.position.x + current_acceleration * speed * Time.deltaTime, player.position.y, player.position.z);
    }
}
