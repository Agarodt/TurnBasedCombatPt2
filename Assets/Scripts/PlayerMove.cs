using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static PlayerMove Instance;
    public GameObject Target;

    void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        
        if (Target != null && PlayerTBC.Instance.playerStep && !PlayerAttackManager.Instance.playerAttackMode)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * 1.2f);
        }
    }
}
