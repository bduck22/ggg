using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D PlayerRb;
    public Animator PlayerAni;
    public Light2D  PlayerLight;

    public GameObject InteractObject;

    public bool Invin;
    public float InvinTime;

    public float MaxAir;
    public float Air;
    public float MaxHp;
    public float Hp;
    public float Speed;

    public void playerHit(int Damage)
    {
        Hp -= Damage;
        Invin = true;
        Invoke("Invinfalse", InvinTime);
    }
    void Invinfalse()
    {
        Invin = false;
    }
}
