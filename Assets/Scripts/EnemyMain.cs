using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMain : MonoBehaviour
{
    void OnMouseDown()
  {
    
        if (PlayerAttackManager.Instance.playerAttackMode && PlayerAttackManager.Instance.ActiveBullet == null)
        {
            PlayerAttackManager.Instance.target = transform;
            PlayerAttackManager.Instance.PlayerAttack();
        }
  }
}
