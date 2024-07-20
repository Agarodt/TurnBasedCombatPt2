using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    int lives = 3;
    [SerializeField]
    bool dead;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "EnemyBullet")
        {
            Destroy(other.gameObject);
            lives -= 1;
        }
    }

    void Update()
    {
        if (lives <= 0 && !dead)
        {   
            dead = true;
            StartCoroutine(RestartLevel());
        }
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
