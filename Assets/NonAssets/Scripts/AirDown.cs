using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AirDown : MonoBehaviour
{
    public float DownAirFerSecond;
    void Start()
    {
        
    }
    void Update()
    {
        PlayerManager.instance.Air -= DownAirFerSecond * Time.deltaTime;
        //Camera.main.GetComponent<Volume>().profile.
    }
}
