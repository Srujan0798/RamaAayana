using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void SaveAtRestPoint(string restPointId)
    {
        Debug.Log($"Saving at rest point: {restPointId}");
        // TODO: Integrate with Unity serialization or cloud save.
    }

    public void LoadLastSave()
    {
        Debug.Log("Loading last save.");
        // TODO: Implement load logic.
    }
}
