using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
    }
    public Rigidbody2D PlayerRb;
    public Animator PlayerAni;
    public Light2D  PlayerLight;

    public float MaxAir;
    public float Air;
    public float MaxHp;
    public float Hp;
    public float Speed;
}
