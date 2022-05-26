using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shotsPerSecond = 1f;
    bool canShoot = true;

    public RaycastHit2D hit;
    public float detectionRange = 5f;

    void Start()
    {
       
    }

    void Update()
    {
        if(canShoot == true)
            StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        canShoot = false;
        GameObject bullet = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        yield return new WaitForSeconds(shotsPerSecond);
        canShoot = true;
    }

    private void OnDrawGizmos()
    {
        if (hit.transform != null)
            Gizmos.DrawWireSphere(hit.point, .25f);

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.left * detectionRange);
    }
}
