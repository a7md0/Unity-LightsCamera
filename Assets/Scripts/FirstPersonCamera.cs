using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    private float xInput, yInput;
    public GameObject camObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Mouse X"); // left-right
        yInput = Input.GetAxis("Mouse Y"); // up-down

        camObject.transform.Rotate(new Vector3(-yInput, xInput, 0));
    }
}
