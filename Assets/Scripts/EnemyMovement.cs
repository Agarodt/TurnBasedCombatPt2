using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform target;
    
    public int currentTurn;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        TBCManagement.Instance.numOfEnemies += 1;
    }

    
    void Update()
    {
        if(!PlayerTBC.Instance.playerStep && currentTurn == TBCManagement.Instance.enemyTurn)
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime);
    }
}
