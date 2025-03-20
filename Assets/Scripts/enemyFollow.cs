using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private Transform player; // player
    [SerializeField] private float speed = 2f; // enemy speed

    void Update()
    {
        if (player != null) // check where is a player
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}