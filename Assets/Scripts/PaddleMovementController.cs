using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementController : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;

    private Vector3 rotationAxis = new Vector3(0, 0, 1);
    private Vector3 pivotPoint = new Vector3(0, 0, 0);

    private void ReverseRotation()
    {
        speed *= -1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ReverseRotation();
        transform.RotateAround(pivotPoint, rotationAxis, speed * Time.deltaTime);
    }
}
