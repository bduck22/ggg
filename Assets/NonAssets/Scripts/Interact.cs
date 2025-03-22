using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public InteractType interactType;
    public Animator Target;
    public void interact()
    {
        GetComponent<CapsuleCollider2D>().enabled = false;
        switch (interactType)
        {
            case InteractType.Lever:Target.enabled = true ; transform.localRotation = Quaternion.Euler(0,0,0); break;
            case InteractType.NextFloor:break;
        }
    }
}
