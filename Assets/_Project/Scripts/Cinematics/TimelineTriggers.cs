using UnityEngine;

public class TimelineTriggers : MonoBehaviour
{
    [SerializeField] private string cinematicId;
    [SerializeField] private GameManager gameManager;

    public void Trigger()
    {
        if (gameManager == null)
        {
            Debug.LogWarning("Missing GameManager reference.");
            return;
        }

        gameManager.PlayCinematic(cinematicId);
    }
}
