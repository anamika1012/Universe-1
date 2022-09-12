using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe1_MouseLook : MonoBehaviour
//https://www.youtube.com/watch?v=_QajrabyTJc
{
    public float MouseSensitivity = 100f;
    //this variable controls the speed of the mouse
    public Transform PlayerBody;
    float xRotation = 0f;
    float yRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //this line is to hide the ouse cursor in game
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
        //these 2 variables will store the movement input from mouse

        //this enables us to look horizontally (rotate around Y Axis)
        //InvalidOperationException: You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling to Input System package in Player Settings.
        //MouseLook.Update()  this is a but that will appear after this line was added, to fix this 
        //Project Settings > Player > Active Input Handling change it to both and add camera to playerbody
        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);//this line prevent player to rotate over its head/crotch
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
        //line 31-33 is for the function to be able to look up and down
        //remember Quaternion is about rotation

    }
}