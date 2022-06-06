using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hp : MonoBehaviour
{
    public TextMeshProUGUI myText;

    void Start()
    {

    }

    void Update()
    {
        myText.text =  Enemy.currentHp + " / " + Enemy.maxHp;
    }
}
