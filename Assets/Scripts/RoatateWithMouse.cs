using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoatateWithMouse : MonoBehaviour
{
    public float speed = 10.0f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X") * speed, 0);
        }
    }
}
