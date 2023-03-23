using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementController : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;

    public bool overlapping = false;

    public void ReverseRotation()
    {
        speed *= -1;
    }

    void Update()
    {
        transform.RotateAround(GameManager.pivotPoint, GameManager.rotationAxis, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        overlapping = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        overlapping = false;
    }
}
