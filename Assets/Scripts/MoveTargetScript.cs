using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerTBC.Instance.MoveTarget = gameObject;
        PlayerMove.Instance.Target = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
