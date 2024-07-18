using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    public static PlayerAttackManager Instance;
    [SerializeField]
    public Texture2D cursor;
    public bool playerAttackMode;
    public Transform target;
    [SerializeField]
    GameObject PlayerBullet;
    [SerializeField]
    float shootCost = 3;
    public GameObject ActiveBullet;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
    if (playerAttackMode && Input.GetMouseButtonDown(1) && ActiveBullet == null)
    {
      AttackFinished();
    }
    }

    public void AttackReady()
    {
        if (PlayerTBC.Instance.playerStep && PlayerTBC.Instance.timer + shootCost < PlayerTBC.Instance.APMax && !playerAttackMode)
        {
           Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
           playerAttackMode = true;
        }
    }

    public void PlayerAttack()
    {

       GameObject projectile = Instantiate(PlayerBullet,Player.Instance.transform.position,Player.Instance.transform.rotation);
       projectile.GetComponent<PlayerBullet>().target = target;
       PlayerTBC.Instance.timer += shootCost;
       
    }

    public void AttackFinished()
    {
       Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
       playerAttackMode = false;
    }
}
