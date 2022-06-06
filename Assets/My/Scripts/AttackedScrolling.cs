using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackedScrolling : MonoBehaviour
{
    //public scroll prefab;

    public GameObject text;
    public Transform getpos;

    public float offsetY = 5f;

    public void OnAttack(GameObject attacker, int damage)
    {
        text.GetComponent<ScrollText>().damage = damage;

        var s = transform.position;
        var pos = getpos.position;
        //pos.y += offsetY;

        pos.y += offsetY;
        text.transform.position = pos;
        var go = Instantiate(text);

        // prefab.Init(attack.Damage.ToString(), Color.red);
        // text.transform.position = attacker.transform.position;
    }
}