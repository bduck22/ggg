using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D Rb;
    Light2D Lg;
    PlayerManager PlayerManager;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;

        Rb = PlayerManager.PlayerRb;
        Lg = PlayerManager.PlayerLight;
    }
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Lg.transform.localRotation = Quaternion.Euler(0, 0, 270);
            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            Rb.velocity = new Vector2(Input.GetAxis("Horizontal")* PlayerManager.Speed, Rb.velocity.y);
        }
        else
        {
            Rb.velocity = new Vector2(0, Rb.velocity.y);
        }

        if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                Lg.transform.localRotation = Quaternion.Euler(0, 0, 180);
            }
            else
            {
                Lg.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            Rb.velocity = new Vector2(Rb.velocity.x, Input.GetAxis("Vertical") * PlayerManager.Speed);
        }
        else
        {
            Rb.velocity = new Vector2(Rb.velocity.x, 0);
        }

        if (!Input.GetButton("Horizontal")&& !Input.GetButton("Vertical"))
        {
            PlayerManager.PlayerAni.SetTrigger("Stop");
            Rb.velocity = new Vector2(0, 0);
        }
        else
        {
            PlayerManager.PlayerAni.SetTrigger("Walk");
            PlayerManager.PlayerAni.SetFloat("Speed", PlayerManager.Speed/6.5f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerManager.PlayerAni.SetTrigger("Attack");
        }
    }
}
