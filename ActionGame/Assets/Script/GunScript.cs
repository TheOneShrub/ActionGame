using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;

    public Transform attackPoint;
    public GameObject muzzleFlash;
    public GameObject impactEffect;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        GameObject flash = Instantiate(muzzleFlash, attackPoint.position, Quaternion.identity);
        Destroy(flash, 0.2f);

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            EnemyScript enemy = hit.transform.GetComponent<EnemyScript>();

            if(enemy != null){
                enemy.TakeDamage(damage);
            }
            if(hit.transform.CompareTag("Enemy"))
            {
                GameObject bloodSplat = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(bloodSplat, 1.1f);
            }
        }
    }
}
