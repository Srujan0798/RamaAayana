using UnityEngine;

public class PrologueSequenceController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private string gateCinematicId = "Prologue_Gate";
    [SerializeField] private string flowerTriggerId = "Flower";
    [SerializeField] private string gateTriggerId = "Gate";

    private bool flowerTriggered;
    private bool gateTriggered;

    public void OnTriggerReached(string triggerId)
    {
        if (triggerId == flowerTriggerId && !flowerTriggered)
        {
            flowerTriggered = true;
            return;
        }

        if (triggerId == gateTriggerId && !gateTriggered)
        {
            gateTriggered = true;
            if (gameManager != null)
            {
                gameManager.PlayCinematic(gateCinematicId);
            }
            else
            {
                Debug.LogWarning("Missing GameManager reference.");
            }
        }
    }
}
