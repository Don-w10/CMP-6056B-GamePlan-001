using UnityEngine;

public class EnergyNode : MonoBehaviour
{
    public GameManager gameManager;

    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;
            gameManager.CollectNode();
            gameObject.SetActive(false);
        }
    }
}