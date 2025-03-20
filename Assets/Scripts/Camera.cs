using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // player link
    public Vector3 offset = new Vector3(0f, 5f, -5f); // camera shift

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
            transform.LookAt(player); // camera looks at the player
        }
    }
}