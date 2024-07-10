using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        float myRandomNumber = Random.Range(0f, 15f);
        Debug.Log(myRandomNumber);
    }
}
