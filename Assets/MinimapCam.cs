using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCam : MonoBehaviour
{
    public Transform player;
    private void LateUpdate()
    {
        Vector3 position= player.position;
        position.y = transform.position.y;
        transform.position = position;  
    }
}
