using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CinematicManager : MonoBehaviour
{
    [SerializeField] private PlayableDirector director;
    [SerializeField] private TimelineAsset[] cinematicSequences;

    private PlayerController currentPlayer;

    public void PlayCinematic(string sequenceId, PlayerController player)
    {
        currentPlayer = player;

        var sequence = System.Array.Find(cinematicSequences, s => s.name == sequenceId);
        if (sequence == null)
        {
            Debug.LogError($"Cinematic {sequenceId} not found");
            return;
        }

        player.SetCinematicState(true);
        director.playableAsset = sequence;

        foreach (var output in sequence.outputs)
        {
            if (output.streamName == "PlayerAnimation")
            {
                director.SetGenericBinding(output.sourceObject, player.GetComponent<Animator>());
            }
        }

        director.Play();
        director.stopped += OnCinematicEnded;
    }

    private void OnCinematicEnded(PlayableDirector obj)
    {
        director.stopped -= OnCinematicEnded;
        currentPlayer?.SetCinematicState(false);
    }
}
