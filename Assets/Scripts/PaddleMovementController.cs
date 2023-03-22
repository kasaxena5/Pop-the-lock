using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementController : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;

    

    private void ReverseRotation()
    {
        speed *= -1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ReverseRotation();
        transform.RotateAround(GameManager.pivotPoint, GameManager.rotationAxis, speed * Time.deltaTime);
    }
}
