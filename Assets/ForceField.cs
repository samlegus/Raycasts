using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    public float radius = 2f;
    RaycastHit2D[] hits;

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            hits = Physics2D.CircleCastAll(transform.position, radius, Vector2.zero);
            foreach(RaycastHit2D hit in hits)
            {
                if(hit.transform.tag == "Bullet")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if(Input.GetButton("Fire2"))
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
}
