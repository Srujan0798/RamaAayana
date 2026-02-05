using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    [SerializeField] private string triggerId;
    [SerializeField] private PrologueSequenceController sequenceController;

    void OnTriggerEnter(Collider other)
    {
        if (sequenceController == null)
        {
            Debug.LogWarning("Missing PrologueSequenceController reference.");
            return;
        }

        if (other.GetComponent<PlayerController>() != null)
        {
            sequenceController.OnTriggerReached(triggerId);
        }
    }
}
