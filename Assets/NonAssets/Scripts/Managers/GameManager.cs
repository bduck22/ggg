using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

        Init();
    }

    public int Stage;
    public List<GameObject> Chests;
    public List<int> Inventory;

    public Transform InteractUi;
    public PlayerManager PlayerManager;

    void Init()
    {
        PlayerManager.InvenInit();
    }
}
