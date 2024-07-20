using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField]
    float destroyTimer = 3f;
    void Start()
    {
        StartCoroutine(DestroyObj());
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(destroyTimer);
        Destroy(gameObject);
    }
}
