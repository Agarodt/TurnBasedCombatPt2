using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesTurnManager : MonoBehaviour
{
    public static EnemiesTurnManager Instance;
    [SerializeField]
    List<GameObject> enemies = new List<GameObject>();
    [SerializeField]
    bool recal;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerTBC.Instance.playerStep && !recal)
        {
            Recalculate();
        }
        if(PlayerTBC.Instance.playerStep)
        {
            recal = false;
        }
    }

    public void AddToList(GameObject enemy)
    {
     enemies.Add(enemy);
    }

    void Recalculate()
    {
        enemies.RemoveAll(GameObject => GameObject == null);
        for (int i = 0; i < enemies.Count; i ++)
        {
            enemies[i].GetComponent<EnemyMovement>().currentTurn = i;
        }
        recal = true;

    }
}
