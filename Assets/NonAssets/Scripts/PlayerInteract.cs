using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager.instance.InteractObject = collision.transform.gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (PlayerManager.instance.InteractObject)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerManager.instance.InteractObject.GetComponent<Interact>().interact();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerManager.instance.InteractObject = null;
    }
}
