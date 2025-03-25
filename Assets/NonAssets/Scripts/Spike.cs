using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    PlayerManager PlayerManager;
    [SerializeField] int Damage;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
    }
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (!PlayerManager.Invin)
            {
                PlayerManager.playerHit(Damage);
            }
        }
    }
}
