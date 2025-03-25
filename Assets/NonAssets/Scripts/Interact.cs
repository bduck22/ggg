using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public InteractType interactType;
    public Animator Target;
    public int ItemNumber;
    PlayerManager PlayerManager;
    private void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
    }
    public void interact()
    {
        GetComponent<CapsuleCollider2D>().enabled = false;
        switch (interactType)
        {
            case InteractType.Lever:Target.enabled = true ; transform.localRotation = Quaternion.Euler(0,0,0); break;
            case InteractType.NextFloor:break;
            case InteractType.Item:PlayerManager.CollectItem(ItemNumber); gameObject.SetActive(false); break;
        }
    }
}
