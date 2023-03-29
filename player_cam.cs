using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_cam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform cam;
    public Transform orientation;
    public Transform sprite;

    float xRotation;
    float yRotation;
    float multiplier = 0.01f;

    [Header("Interactive UI")]
    public Transform interactive_ui;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void checkInteractUI()
    {
        if (Vector3.Distance(interactive_ui.position, transform.position) < offset)
        {
            interactive_ui.gameObject.SetActive(true);
        }
        else
        {
            interactive_ui.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkInteractUI();
        float mouseX = Input.GetAxisRaw("Mouse X") * multiplier * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * multiplier * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.transform.rotation = Quaternion.Euler(0, yRotation, 0);
        sprite.transform.rotation = Quaternion.Euler(-90, 0, yRotation);
    }
}
