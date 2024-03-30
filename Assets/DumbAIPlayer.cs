using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbAIControls : MonoBehaviour
{
    public Transform target; // Transform guarda rotação, posição, escala, etc.
    public float speed = 10.0f;

    void Update()
    {
        float step = speed * Time.deltaTime; // m/s * s = m
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, target.position.y), step);
        /**
        * @param Vector2    current
        * @param Vector2    target
        * @param float      DeltaS_Max
        */
    }
}
