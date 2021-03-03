using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private float xInput, zInput;
    public float speed;

    public Text uiHeader;

    // Update is called once per frame
    void Update() {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(xInput, 0, zInput) * Time.deltaTime * speed);

        uiHeader.text = $"x = {xInput}, z = {zInput}";
    }
}
