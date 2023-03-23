using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text countDownText;

    [SerializeField]
    private Coin coinPrefab;

    [SerializeField]
    private PaddleMovementController paddle;

    private Coin activeCoin;

    public static Vector3 rotationAxis = new Vector3(0, 0, 1);
    public static Vector3 pivotPoint = new Vector3(0, 0, 0);
    public static float coinSpawnTime = 3;

    private void InstantiateCoin()
    {
        activeCoin = Instantiate(coinPrefab);
    }

    void Start()
    {
        InstantiateCoin();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (paddle.overlapping)
            {
                activeCoin.Disappear();
                int cnt = Int32.Parse(countDownText.text);
                cnt--;
                countDownText.text = cnt.ToString();
                paddle.ReverseRotation();
                InstantiateCoin();
            }
        }
    }
}
