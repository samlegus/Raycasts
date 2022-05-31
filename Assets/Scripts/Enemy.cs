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
    public LayerMask mask; //set in editor
    public Transform gun;

    void Update()
    {
        hit = Physics2D.Raycast(gun.position, Vector2.left, 5f, mask);
        if(canShoot == true && hit.transform != null)
            StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        canShoot = false;
        GameObject bullet = Instantiate(projectilePrefab, gun.position, projectilePrefab.transform.rotation);
        yield return new WaitForSeconds(shotsPerSecond);
        canShoot = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        if (hit.transform != null)
        {
            Gizmos.DrawWireSphere(hit.point, .25f);
        }
            
        Gizmos.DrawLine(gun.position, (Vector2)gun.position + Vector2.left * detectionRange);
    }
}
