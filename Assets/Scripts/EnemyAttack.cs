using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    EnemyMovement EM;
    [SerializeField]
    float attackDistance = 5;
    [SerializeField]
    float timer;
    [SerializeField]
    float timeMax = 5;
    [SerializeField]
    float attackCost = 3;
    [SerializeField]
    bool attack;
    [SerializeField]
    GameObject enemyBullet;
    

    void Start()
    {
        EM = GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TBCManagement.Instance.enemyStep && EM.currentTurn == TBCManagement.Instance.enemyTurn)
        {
            timer += Time.deltaTime;
        }
        if (EM.currentTurn != TBCManagement.Instance.enemyTurn || !TBCManagement.Instance.enemyStep)
        {
            timer = 0;
        }

        if(TBCManagement.Instance.enemyStep && EM.currentTurn == TBCManagement.Instance.enemyTurn && EM.distance <= attackDistance && attackCost <= (timeMax - timer) && !attack)
        {
          attack = true;
          GameObject projectile = Instantiate(enemyBullet, transform.position, transform.rotation);
          StartCoroutine(FinishAttack());
        }
        
    }

    IEnumerator FinishAttack()
    {
        yield return new WaitForSeconds(3);
        attack = false;
    }
}
