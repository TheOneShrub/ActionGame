using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Variables for Rotating Camera
    [Range(0f, 10f)] public float rotateSpeed;
    public GameObject playerCamera;

    float rotationY = 0f;
    bool lockedCursor = true;

    // Start is called before the first frame update
    void Start()
    {
        //Lock and hide cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Camera around its X-Axis
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0, mouseX, 0) * rotateSpeed;
        transform.Rotate(rotation);

        //Rotate Camera around its Y-Axis
        float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed;
        rotationY += mouseY;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);
        playerCamera.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
    }
}
