using JetBrains.Annotations;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject box;
    
    private void OnTriggerEnter(Collider other)
    {
        box.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        box.SetActive(false);
    }

}
