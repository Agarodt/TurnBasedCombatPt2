using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    int lives = 1;
    [SerializeField]
    bool dead;


    // Update is called once per frame
    void Update()
    {
        if(lives == 0 && !dead)
        {
            TBCManagement.Instance.numOfEnemies -= 1;
            dead = true;
            Destroy(gameObject,0.1f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PlayerBullet")
        {
            Destroy(other.gameObject);
            lives -= 1;
        }
    }
}
