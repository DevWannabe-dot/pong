using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float multiplier = 1.01f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f))) * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 plrPos, float size)
    {
        return ((ballPos.y - plrPos.y) / size);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player1")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed * multiplier;
            multiplier *= 1.01f;
        }
        if (col.gameObject.name == "CPU")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed * multiplier;
            multiplier *= 1.01f;
        }
    }
}
