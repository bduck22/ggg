using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public InteractType interactType;
    public GameObject Target;
    public void interact()
    {
        switch (interactType)
        {
            case InteractType.Lever:Target.GetComponent<Animator>().enabled = true ; break;
            case InteractType.NextFloor:break;
        }
    }
}
