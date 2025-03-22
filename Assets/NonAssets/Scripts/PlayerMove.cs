using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D Rb;
    Light2D Lg;
    void Start()
    {
        Rb = PlayerManager.instance.PlayerRb;
        Lg = PlayerManager.instance.PlayerLight;
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
            Rb.velocity = new Vector2(Input.GetAxis("Horizontal")* PlayerManager.instance.Speed, Rb.velocity.y);
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
            Rb.velocity = new Vector2(Rb.velocity.x, Input.GetAxis("Vertical") * PlayerManager.instance.Speed);
        }
        else
        {
            Rb.velocity = new Vector2(Rb.velocity.x, 0);
        }

        if (!Input.GetButton("Horizontal")&& !Input.GetButton("Vertical"))
        {
            PlayerManager.instance.PlayerAni.SetTrigger("Stop");
            Rb.velocity = new Vector2(0, 0);
        }
        else
        {
            PlayerManager.instance.PlayerAni.SetTrigger("Walk");
            PlayerManager.instance.PlayerAni.SetFloat("Speed", PlayerManager.instance.Speed/6.5f);
        }
    }
}
