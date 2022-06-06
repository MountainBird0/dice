using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    Vector3 objPosition = new Vector3(0f, 0f, 0f);
    Vector3 force = new Vector3(0f, 0f, 0f);

    public Rigidbody rd;
    private float distance = 5;

    //private void Update()
    //{
    //    force = 
    //}

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Quaternion rota = Quaternion.Euler(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance));
        
        transform.position = objPosition;
        transform.rotation = rota;
    }

    //private void OnMouseUp()
    //{
    //    Debug.Log("sdfsdfsdfsdf");
    //    rd.AddForce(Input.mousePosition.x, Input.mousePosition.y, distance);
    //}
}
