using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    float speed = 5;
    void Start()
    {
        PlayerAttackManager.Instance.ActiveBullet = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
    }

    void OnDestroy()
    {
        PlayerAttackManager.Instance.AttackFinished();
    }
}
