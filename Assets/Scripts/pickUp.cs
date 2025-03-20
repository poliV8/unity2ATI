using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float score = 0;
    [SerializeField] float _collapseSpeed = 5f;
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            StartCoroutine(MoveToPlayer(other.transform, transform, _collapseSpeed));
            score++;
            Debug.Log("Score: " + score);

        }
    }

    IEnumerator MoveToPlayer(Transform coin, Transform player, float speed)
    {
        float duration = 1.5f;
        float time = 0f;


        while (time < duration)
        {
            coin.position = Vector3.MoveTowards(coin.position, player.position, speed * Time.deltaTime);
            time += Time.deltaTime;
            yield return null;
        }

        Destroy(coin.gameObject);

    }
}
