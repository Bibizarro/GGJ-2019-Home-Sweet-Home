using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  
    [SerializeField] private float cooldown;
    private bool canShot;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawn;
    void Start()
    {
        canShot = true;
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKey(KeyCode.Space) && canShot)
    {
     StartCoroutine(Shooting());
    }

    IEnumerator Shooting()
    {
        canShot = false;
        Instantiate(bullet , bulletSpawn.position ,Quaternion.identity);
        yield return new WaitForSeconds(cooldown);
        canShot = true;
    }

    }
}
