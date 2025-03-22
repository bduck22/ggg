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
        Air
    }
    [SerializeField]UiType type;
    TMP_Text text;
    Image image;
    void Start()
    {
        image = transform.parent.GetComponent<Image>();
        text = GetComponent<TMP_Text>();
    }
    void Update()
    {
        switch (type)
        {
            case UiType.Hp:text.text = PlayerManager.instance.Hp.ToString("#,###") + " / "+PlayerManager.instance.MaxHp.ToString("#,###"); image.fillAmount= PlayerManager.instance.Hp/ PlayerManager.instance.MaxHp; break;
            case UiType.Air: text.text = PlayerManager.instance.Air.ToString("#,###") + " / " + PlayerManager.instance.MaxAir.ToString("#,###"); image.fillAmount = PlayerManager.instance.Air / PlayerManager.instance.MaxAir; break;
        }
    }
}
