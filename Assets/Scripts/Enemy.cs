using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform gun;
    public float shotDelay = 1f;
    bool canShoot = true;

    void Update()
    {
        if (canShoot == true)
            StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        canShoot = false;
        GameObject bullet = Instantiate(projectilePrefab, gun.position, projectilePrefab.transform.rotation);
        yield return new WaitForSeconds(shotDelay);
        canShoot = true;
    }

    private void OnDrawGizmos()
    {
 
    }
}
