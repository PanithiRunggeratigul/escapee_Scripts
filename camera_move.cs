using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = cameraPosition.position;
    }
}
