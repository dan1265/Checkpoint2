using UnityEngine;

public class Halberd : MonoBehaviour
{
    public GameObject playerHalberd;
    public GameObject dropHalberd;
    public bool getHalberd;

    public GameObject pressE;

    // Update is called once per frame
    private void Start()
    {
        getHalberd = false;
        playerHalberd.SetActive(false);
        dropHalberd.SetActive(true);
        pressE.SetActive(false);
    }
    void Update()
    {
        if (getHalberd)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                getHalberd = true;
                playerHalberd.SetActive(true);
                dropHalberd.SetActive(false);
            }
            if(!playerHalberd.activeInHierarchy)
                pressE.SetActive(true);
            else
                pressE.SetActive(false);
        }
        if (playerHalberd.activeInHierarchy || !getHalberd)
            pressE.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            getHalberd = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            getHalberd = false;
        }
    }
}
