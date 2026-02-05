using UnityEngine;

public class WorldStateManager : MonoBehaviour
{
    [SerializeField] private DharmaSystem dharmaSystem;
    [SerializeField] private Light mainLight;
    [SerializeField] private Color highDharmaLight = new Color(1f, 0.95f, 0.8f);
    [SerializeField] private Color lowDharmaLight = new Color(0.6f, 0.65f, 0.7f);

    void OnEnable()
    {
        if (dharmaSystem != null)
        {
            dharmaSystem.OnDharmaChanged += HandleDharmaChanged;
        }
    }

    void OnDisable()
    {
        if (dharmaSystem != null)
        {
            dharmaSystem.OnDharmaChanged -= HandleDharmaChanged;
        }
    }

    private void HandleDharmaChanged(float normalized)
    {
        if (mainLight == null)
        {
            return;
        }

        mainLight.color = Color.Lerp(lowDharmaLight, highDharmaLight, normalized);
    }
}
