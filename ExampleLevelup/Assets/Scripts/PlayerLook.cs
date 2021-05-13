using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitifity = 100f;
    public Transform playerBody;
    public float xRotation=0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotacia hore dole
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitifity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -100f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        //Rotacia vlavo vpravo
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitifity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);

        
    }
}
