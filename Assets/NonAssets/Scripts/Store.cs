using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    PlayerManager PlayerManager;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
    }
    void Update()
    {
        
    }
    public void BagUpgrade()
    {
        PlayerManager.InvenUpgrade();
    }
    public void AirUpgrade()
    {
        PlayerManager.AirUpgrade();
    }
    public void Exit()
    {
        gameObject.SetActive(false);
        GameManager.Instance.Init();
        PlayerManager.gameObject.SetActive(true);
        GameManager.Instance.Playing = true;
    }
}
