using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController activePlayer;
    [SerializeField] private CinematicManager cinematicManager;

    public void SetActivePlayer(PlayerController controller)
    {
        activePlayer = controller;
    }

    public void PlayCinematic(string sequenceId)
    {
        if (activePlayer == null || cinematicManager == null)
        {
            Debug.LogWarning("Missing active player or CinematicManager.");
            return;
        }

        cinematicManager.PlayCinematic(sequenceId, activePlayer);
    }
}
