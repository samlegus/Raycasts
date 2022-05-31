using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform gun;

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        GameObject bullet = Instantiate(projectilePrefab, gun.position, projectilePrefab.transform.rotation);
    }

    private void OnDrawGizmos()
    {
 
    }
}
