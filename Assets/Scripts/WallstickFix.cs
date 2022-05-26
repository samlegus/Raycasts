using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallstickFix : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D coll;
    public LayerMask mask;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector2 origin = transform.position;
        Vector2 direction = Vector2.right * Mathf.Sign(Input.GetAxisRaw("Horizontal"));
        float detectionDistance = coll.size.x / 2f * 1.1f;

        RaycastHit2D hit = Physics2D.Raycast(origin, direction, detectionDistance, mask);
        if (hit.transform != null)
            rb.velocity = new Vector2(0f, rb.velocity.y);
        else
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);

        Debug.DrawRay(origin, direction * detectionDistance);
    }
}
