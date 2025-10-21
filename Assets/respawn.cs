using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject wall;

    private void OnTriggerEnter(Collider other)
    {
        wall.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        wall.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        wall.SetActive(false);
    }
}
