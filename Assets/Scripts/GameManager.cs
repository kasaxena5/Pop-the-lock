using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text countDownText;

    [SerializeField]
    private Coin coinPrefab;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InstantiateCoin();
        }
    }
}
