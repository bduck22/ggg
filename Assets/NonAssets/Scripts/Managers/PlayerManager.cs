using System.Collections;
using System.Collections.Generic;
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
        for (int i = 0; i < Inventory.Count; i++)
        {
            Images[i].sprite = ItemImages[Inventory[i]];
        }
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
}
