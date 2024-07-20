using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public Transform target;
    
    public int currentTurn;

    public float distance;

    [SerializeField]
    float moveSpeed = 1;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        TBCManagement.Instance.numOfEnemies += 1;
    }

    
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);
        
        if(TBCManagement.Instance.enemyStep && currentTurn == TBCManagement.Instance.enemyTurn && distance > 2)
        {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * moveSpeed);
        }
    }
}
