using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InstantiateCubes : MonoBehaviour
{
    public Transform prefab;

    int counter = 0;

    // Start is called before the first frame update
    /*
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(-15 + i * 3.0F, 0,0), Quaternion.identity);
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3(-15 + counter * 3.0f, 0, 0), Quaternion.identity);
            counter++;
        }
    }

    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3(-10 + counter * 3.0f, 0, 0), Quaternion.identity);
        counter++;

        if(counter >= 5)
        {
            CancelInvoke();
        }
    }

    private void Start()
    {
        // InvokeRepeating("CreateNewCube", 3f, 1f);

        Invoke("CreateNewCube", 5f);
    }
}
