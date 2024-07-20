using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    float speed = 5;
    void Start()
    {
        target = Player.Instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
    }

}

