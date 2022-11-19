using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    [SerializeField] private Transform _cameraPosition;

    void LateUpdate()
    {
        transform.position = new Vector3(_cameraPosition.position.x, _cameraPosition.position.y, -10);
    }
}
