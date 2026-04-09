using UnityEngine;

public class FlowerInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private DharmaSystem dharmaSystem;
    [SerializeField] private bool touchingFlowerIsRestrained = true;

    public void Interact(PlayerController player)
    {
        if (dharmaSystem == null)
        {
            Debug.LogWarning("Missing DharmaSystem reference.");
            return;
        }

        dharmaSystem.RegisterAction(touchingFlowerIsRestrained
            ? DharmaSystem.ActionType.Restraint
            : DharmaSystem.ActionType.Neutral);
    }
}
