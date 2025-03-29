using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D PlayerRb;
    public Animator PlayerAni;
    public Light2D  PlayerLight;

    public Interact InteractObject;

    public bool Invin;
    public float InvinTime;

    public int InventorySize;
    public int Weight;
    public int MaxWeight;

    public float MaxAir;
    public float Air;
    public float MaxHp;
    public float Hp;
    public float Speed;
    public List<int> Inventory;


    [SerializeField] Transform InvenUiParent;
    [SerializeField] private Sprite[] ItemImages;
    [SerializeField] private Image[] Images;

    public void PlayerInit()
    {
        transform.position = GameManager.Instance.StageStartposition[0].position;
        Air = MaxAir;
        Hp = MaxHp;
        InvenInit();
    }
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
    public void CollectItem(int number)
    {
        if(Inventory.Count < InventorySize)
        {
            Inventory.Add(number);
        }
        InvenLoad();
    }
    void InvenLoad()
    {
        for (int i = 0; i < InventorySize; i++)
        {
            Images[i].sprite = null;
        }
        for (int i = 0; i < Inventory.Count; i++)
        {
            Images[i].sprite = ItemImages[Inventory[i]];
        }
    }
    public void Heal(int value)
    {
        Hp+= value;
        if(Hp>MaxHp)Hp= MaxHp;
    }
    public void AirHeal(int value)
    {
        Air += value;
        if (Air > MaxAir) Air = MaxAir;
    }
    public void InvenInit()
    {
        Inventory = new List<int>();
        for(int i = 0; i < InvenUiParent.childCount; i++)
        {
            InvenUiParent.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 0; i < InventorySize; i++)
        {
            InvenUiParent.GetChild(i).gameObject.SetActive(true);
        }
    }

    public void InvenUpgrade()
    {
        InventorySize += 2;
        MaxWeight += 150;
    }
    public void AirUpgrade()
    {
        MaxAir += 50;
    }


    public void UseItem(int number)
    {
        if (Inventory[number] < 7)
        {
            switch (Inventory[number])
            {
                case 0: Heal(20); break;//체력 회복
                case 1: AirHeal(20); break;//산소 회복
                case 2: break;//보물 추적
                case 3: break;//이속 소량
                case 4: break;//이속 대량
                case 5: break;//투명
                case 6: break;//귀환
            }
            Inventory.RemoveAt(number);
            InvenLoad();
        }
    }
}
