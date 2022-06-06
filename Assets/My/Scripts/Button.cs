using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    private int number;
    public TextMeshProUGUI myText;


    void Start()
    {
        
    }

    void Update()
    {
        number = FindObjectOfType<Ground>().GetNumber();
        myText.text = number.ToString();
    }

    public void damage()
    {
        number = FindObjectOfType<Ground>().GetNumber();
        Enemy.currentHp -= number;
    }
}
