using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100))
        {
            print("Hit " + hit.collider.gameObject.name);
        }

        /*
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100f))
        {
            print("We hit something at " + hit.transform.position);
        }
        else
        {
            print("Nothing underneath us");
        }
        */
    }
}
