using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector2 minCameraPos;
    [SerializeField] private Vector2 maxCameraPos;

    [SerializeField]private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        //transform.position = 
        pos.x = Singleton.GetInstance.player.transform.position.x;
        pos.x = Mathf.Clamp(pos.x,minCameraPos.x , maxCameraPos.x);

        pos.y = Singleton.GetInstance.player.transform.position.y;
        pos.y = Mathf.Clamp(pos.y,minCameraPos.y, maxCameraPos.y);

        transform.position = new Vector3(pos.x,pos.y ,transform.position.z);
    }
}
