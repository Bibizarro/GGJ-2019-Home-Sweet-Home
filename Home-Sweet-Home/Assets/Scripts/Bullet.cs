using System.Collections;
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
 transform.eulerAngles = new Vector2(0,0);
shotDirection = -GameObject.Find("Fingertip").transform.up;
}
void Update()
{
   
transform.Translate(shotDirection * speed);
}

void FixedUpdate()
{

RaycastHit2D hit = Physics2D.Raycast(transform.position , transform.up , rayDistance);

if(hit.collider != null)
{
 if(hit.collider.CompareTag("Family"))
{
 hit.collider.gameObject.SendMessage("Die");
 gameObject.SetActive(false);
}

else  if(hit.collider.CompareTag("Bounds"))
{
    gameObject.SetActive(false);
}

}
}
IEnumerator SelfDestruct()
{
yield return new WaitForSeconds(lifeTime);
gameObject.SetActive(false);
}

    }
   
