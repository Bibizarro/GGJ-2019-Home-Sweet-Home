using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beholder : MonoBehaviour
{
    
    private float x;
    private float y;    
    public float width;

    public float height;

    public float speed;

    float timeCounter;

    [SerializeField] private Vector2 offset;

    
    void Update()
    {
        timeCounter += Time.deltaTime;
        x = Mathf.Cos(timeCounter*speed) * width;
        y = Mathf.Sin(timeCounter*speed) * height;

        transform.position =  new Vector3(x+offset.x, y + offset.y, transform.position.z);
    }
}
