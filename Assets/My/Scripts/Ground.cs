using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private int number;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "1")
        {
            Debug.Log("6");
            number = 6;
        }

        if (other.tag == "2")
        {
            Debug.Log("5");
            number = 5;
        }

        if (other.tag == "3")
        {
            Debug.Log("4");
            number = 4;
        }

        if (other.tag == "4")
        {
            Debug.Log("3");
            number = 3;
        }

        if (other.tag == "5")
        {
            Debug.Log("2");
            number = 2;
        }

        if (other.tag == "6")
        {
            Debug.Log("1");
            number = 1;
        }
    }

    public int GetNumber()
    {
        return number;
    }
}
