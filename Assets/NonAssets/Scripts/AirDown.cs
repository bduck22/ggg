using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AirDown : MonoBehaviour
{
    public float DownAirFerSecond;
    PlayerManager PlayerManager;
    Volume volume;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
        volume = Camera.main.GetComponent<Volume>();
    }
    void Update()
    {
        PlayerManager.Air -= DownAirFerSecond * Time.deltaTime;
        volume.weight = 1- PlayerManager.Air/ PlayerManager.MaxAir;
    }
}
