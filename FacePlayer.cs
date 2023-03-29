using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform cam;
    public float offset;

    private void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
