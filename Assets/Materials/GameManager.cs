using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI counterText;
    public GameObject winText;

    [Header("Game")]
    public int totalNodes = 6;

    private int collected = 0;

    private void Start()
    {
        UpdateUI();
        if (winText != null)
            winText.SetActive(false);
    }

    public void CollectNode()
    {
        collected++;
        UpdateUI();

        if (collected >= totalNodes)
        {
            if (winText != null)
                winText.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    private void UpdateUI()
    {
        if (counterText != null)
            counterText.text = "Nodes: " + collected + "/" + totalNodes;
    }
}
