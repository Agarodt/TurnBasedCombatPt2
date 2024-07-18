using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTBC : MonoBehaviour
{
    public static PlayerTBC Instance;
    public float APMax = 5;
    public float timer;
    public bool playerStep = true;
    public GameObject MoveTarget;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (MoveTarget != null && playerStep)
        {
            timer += Time.deltaTime;

        }
        if (timer > APMax)
        {
            playerStep = false;
            timer = 0;
        }
    }
}
