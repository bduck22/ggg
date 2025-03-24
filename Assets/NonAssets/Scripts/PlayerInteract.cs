using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    PlayerManager PlayerManager;
    Transform EGuide;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
        EGuide = GameManager.Instance.InteractUi;
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager.InteractObject = collision.GetComponent<Interact>();
        EGuide.position = collision.transform.position+new Vector3(0,1);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (PlayerManager.InteractObject)
        {
            Debug.Log("aa");
            EGuide.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("bb");
                PlayerManager.InteractObject.interact();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EGuide.gameObject.SetActive(false);
        PlayerManager.InteractObject = null;
    }
}
