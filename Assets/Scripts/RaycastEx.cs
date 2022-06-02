using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastEx : MonoBehaviour
{
    public float distance = 5f;
    RaycastHit2D hit;
    RaycastHit2D[] hits;

    private void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }
    void Update()
    {
        //hit = Physics2D.Raycast(transform.position, Vector2.right, distance);
        hits = Physics2D.RaycastAll(transform.position, Vector2.right, distance);
        Debug.DrawRay(transform.position, Vector2.right * distance);
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawWireSphere(hit.point, .25f);
        if(hits != null)
        {
            foreach (RaycastHit2D hit in hits) //Iterate over all the points of contact
            {
                Gizmos.DrawWireSphere(hit.point, .25f);
            }
        }
    }
}
