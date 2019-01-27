using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
[SerializeField] private string sceneName;
[SerializeField] private Animator transitions;
[SerializeField] private float changeTime;

IEnumerator LoadingScene()
{
Singleton.GetInstance.player.GetComponent<PlayerMove>().curSpeed = 0;
transitions.SetTrigger("fadeIn");
yield return new WaitForSeconds(changeTime);
SceneManager.LoadScene(sceneName);
}

private void OnTriggerEnter2D(Collider2D other) 
{
    if(other.tag == "Player")
    {
        StartCoroutine(LoadingScene());
    }
}

}
