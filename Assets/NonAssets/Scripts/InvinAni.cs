using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvinAni : MonoBehaviour
{
    SpriteRenderer Sprite;
    float blinkTime;
    PlayerManager PlayerManager;
    void Start()
    {
        blinkTime = 0;
        Sprite = GetComponent<SpriteRenderer>();
        PlayerManager = GameManager.Instance.PlayerManager;
    }
    void Update()
    {
        if (PlayerManager.Invin)
        {
            blinkTime += Time.deltaTime;
            if (blinkTime > 0.2f)
            {
                if (blinkTime > 0.4f) blinkTime = 0;
                Sprite.color = Color.white - (Color.black * 0.3f);
            }
            else
            {
                Sprite.color = Color.white;
            }
        }
        else
        {
            Sprite.color = Color.white; blinkTime = 0;
        }
    }
}
