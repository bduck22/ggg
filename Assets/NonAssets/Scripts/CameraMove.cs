using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float CameraSpeed;
    Vector3 PlayerPosition;
    bool x;
    bool y;
    PlayerManager PlayerManager;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
        x = true;
        y=true;
    }
    void Update()
    {
        PlayerPosition = PlayerManager.transform.position;
        if (PlayerPosition.y > -12&& PlayerPosition.y < 27f)
        {
            y = false;
        }
        else y = true;
        if(PlayerPosition.x > -12 && PlayerPosition.x < 13)
        {
            x = false;
        }
        else x = true;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3((x?transform.position.x: PlayerPosition.x), (y? transform.position.y: PlayerPosition.y), -10), CameraSpeed * Time.deltaTime);
    }
}
