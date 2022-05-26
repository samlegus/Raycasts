using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2.5f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

}
