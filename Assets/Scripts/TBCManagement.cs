using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBCManagement : MonoBehaviour
{
    public static TBCManagement Instance;
    [SerializeField]
    float timer;
    [SerializeField]
    float maxTime = 5;
    public int numOfEnemies;
    public int enemyTurn;
    [SerializeField]
    float currentTime;
    [SerializeField]
    bool enemyStep;

    void Awake()
    {
        Instance = this;
    }

    
    void Update()
    {
        if(!PlayerTBC.Instance.playerStep && !enemyStep)
        {
            enemyStep = true;
            currentTime = maxTime;
        }

        if(enemyStep)
        {
            timer += Time.deltaTime;
        }

        if (timer > currentTime)
        {
          currentTime += maxTime;
          enemyTurn += 1;
        }

        if (timer > maxTime * numOfEnemies)
        {
            PlayerTBC.Instance.playerStep = true;
            timer = 0;
            currentTime = 0;
            enemyTurn = 0;
            enemyStep = false;
        }

       
    }
}
