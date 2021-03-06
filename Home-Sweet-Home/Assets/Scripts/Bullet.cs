﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] private float speed;
[SerializeField] private float lifeTime;
[SerializeField] private float rayDistance;

private GameObject fingertip;

private Vector3 shotDirection;


void Start()
{
StartCoroutine(SelfDestruct());
shotDirection = -Singleton.GetInstance.fingertip.transform.up;
}
void Update()
{
transform.Translate(shotDirection * speed);
}

void FixedUpdate()
{

RaycastHit2D hit = Physics2D.Raycast(transform.position , transform.up , rayDistance);

if(hit.collider.CompareTag("Family"))
{
//vai killar
}

else if(hit.collider.CompareTag("Bounds"))
{
    gameObject.SetActive(false);
}

}

IEnumerator SelfDestruct()
{
yield return new WaitForSeconds(lifeTime);
gameObject.SetActive(false);
}

    }
   
