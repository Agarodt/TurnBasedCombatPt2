using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstantiateTarget : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    GameObject moveTarget;
    Vector3 mouseWorldPos;
    
   void Start()
   {
    camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
   }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        mouseWorldPos = camera.ScreenToWorldPoint(mousePos);
        mouseWorldPos.z = 0;
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && !PlayerAttackManager.Instance.playerAttackMode)
        {
           GameObject ActiveTarget = GameObject.FindGameObjectWithTag("MoveTarget");
           if (ActiveTarget != null)
           {
            Destroy(ActiveTarget);
           }
           StartCoroutine(CreateNewTarget());
           
        }
    }

    IEnumerator CreateNewTarget()
    {
        yield return new WaitForSeconds(0.1f);
        Instantiate(moveTarget, mouseWorldPos, Quaternion.identity);
    }
}
