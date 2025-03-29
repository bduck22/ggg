using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiPrint : MonoBehaviour
{
    enum UiType
    {
        Hp,
        Air,
        Weight
    }
    [SerializeField]UiType type;
    TMP_Text text;
    Image image;
    PlayerManager PlayerManager;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
        image = transform.parent.GetComponent<Image>();
        text = GetComponent<TMP_Text>();
    }
    void Update()
    {
        switch (type)
        {
            case UiType.Hp:text.text = PlayerManager.Hp.ToString("#,##0") + " / "+PlayerManager.MaxHp.ToString("#,##0"); 
                image.fillAmount= PlayerManager.Hp/ PlayerManager.MaxHp; 
                break;
            case UiType.Air: text.text = PlayerManager.Air.ToString("#,##0") + " / " + PlayerManager.MaxAir.ToString("#,##0"); 
                image.fillAmount = PlayerManager.Air / PlayerManager.MaxAir; 
                break;
            case UiType.Weight: text.text = PlayerManager.Weight.ToString("#,##0kg") + " / " + PlayerManager.MaxWeight.ToString("#,##0kg");
                break;
        }
    }
}
