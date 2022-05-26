using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shotsPerSecond = 1f;
    bool canShoot = true;

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
}
