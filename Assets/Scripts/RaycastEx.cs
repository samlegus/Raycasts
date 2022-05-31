using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastEx : MonoBehaviour
{
    public float distance = 5f;
    RaycastHit2D hit;

    void Update()
    {
        hit = Physics2D.Raycast(transform.position, Vector2.right, distance);
    }

    private void OnDrawGizmos()
    {
        if(hit.transform != null)
        {
            Gizmos.DrawWireSphere(hit.point, .25f);
        }
    }
}
