using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject == PlayerManager.instance.gameObject)
        {
            if (!PlayerManager.instance.Invin)
            {
                PlayerManager.instance.playerHit(1);
            }
        }
    }
}
