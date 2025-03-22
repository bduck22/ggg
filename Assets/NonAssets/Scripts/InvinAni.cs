using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvinAni : MonoBehaviour
{
    SpriteRenderer Sprite;
    float blinkTime;
    void Start()
    {
        blinkTime = 0;
        Sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (PlayerManager.instance.Invin)
        {
            blinkTime += Time.deltaTime;
            if (blinkTime > 0.2f)
            {
                if (blinkTime > 0.4f) blinkTime = 0;
                Sprite.color = new Color32(255, 255, 255, 200);
            }
            else
            {
                Sprite.color = new Color32(255, 255, 255, 255);
            }
        }
        else
        {
            Sprite.color = new Color32(255, 255, 255, 255); blinkTime = 0;
        }
    }
}
