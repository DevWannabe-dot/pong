using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 10.0f;
    public string axis;

    void Update()
    {
        float v = Input.GetAxisRaw(axis); // retorna v inteiro [-1, 1]
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * speed; // move-se em \cos{\pm \pi} * escalar (constante)
    }
}
