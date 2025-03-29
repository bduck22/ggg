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
        volume = GetComponent<Volume>();
    }
    void Update()
    {
        if (GameManager.Instance.Playing)
        {
            PlayerManager.Air -= DownAirFerSecond * Time.deltaTime;
            volume.weight = 1 - PlayerManager.Air / PlayerManager.MaxAir;
        }else
        {
            PlayerManager.gameObject.SetActive(false);
        }
    }
}
