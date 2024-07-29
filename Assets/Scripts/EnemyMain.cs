using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMain : MonoBehaviour
{
     void Start()
    {
        EnemiesTurnManager.Instance.AddToList(gameObject);
    }

    void OnMouseDown()
    {
    
        if (!EventSystem.current.IsPointerOverGameObject() && PlayerAttackManager.Instance.playerAttackMode && PlayerAttackManager.Instance.ActiveBullet == null)
        {
            PlayerAttackManager.Instance.target = transform;
            PlayerAttackManager.Instance.PlayerAttack();
        }
    }
}
