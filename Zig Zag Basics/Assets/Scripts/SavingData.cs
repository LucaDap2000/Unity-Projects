using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingData : MonoBehaviour
{
    int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Stored number is: " + GetNumber());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            number++;
            if(number > GetNumber())
            {
                PlayerPrefs.SetInt("MyNumber", number);
            }
            Debug.Log(number);
        }
    }

    int GetNumber()
    {
        int myNumber = PlayerPrefs.GetInt("MyNumber", 0);
        return myNumber;
    }
}
