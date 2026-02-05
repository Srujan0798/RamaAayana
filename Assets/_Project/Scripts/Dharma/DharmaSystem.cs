using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DharmaSystem : MonoBehaviour
{
    [Header("Dharma Settings")]
    [SerializeField] private float maxDharma = 100f;
    [SerializeField] private float startingDharma = 50f;
    [SerializeField] private float decayRate = 0.5f;

    [Header("World Feedback")]
    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private AudioMixerGroup musicMixer;

    private float currentDharma;
    private ColorAdjustments colorAdjustments;
    private Vignette vignette;

    public static DharmaSystem Instance { get; private set; }
    public event System.Action<float> OnDharmaChanged;
    public event System.Action<DharmaTier> OnTierChanged;

    public enum DharmaTier { Sattvic, Rajasic, Tamasic }

    void Awake()
    {
        Instance = this;
        currentDharma = startingDharma;

        if (postProcessVolume != null && postProcessVolume.profile != null)
        {
            postProcessVolume.profile.TryGet(out colorAdjustments);
            postProcessVolume.profile.TryGet(out vignette);
        }
    }

    void Update()
    {
        ModifyDharma(-decayRate * Time.deltaTime / 60f);
    }

    public void RegisterAction(ActionType type)
    {
        float change = type switch
        {
            ActionType.Restraint => 5f,
            ActionType.Defense => 3f,
            ActionType.Neutral => 0f,
            ActionType.Aggression => -5f,
            ActionType.Cruelty => -10f,
            _ => 0f
        };

        ModifyDharma(change);
    }

    private void ModifyDharma(float amount)
    {
        currentDharma = Mathf.Clamp(currentDharma + amount, 0f, maxDharma);
        float normalized = currentDharma / maxDharma;
        OnDharmaChanged?.Invoke(normalized);
        UpdateWorldState(normalized);
    }

    private void UpdateWorldState(float normalized)
    {
        if (colorAdjustments != null)
        {
            colorAdjustments.saturation.value = Mathf.Lerp(-50f, 20f, normalized);
            colorAdjustments.contrast.value = Mathf.Lerp(20f, 0f, normalized);
        }

        if (vignette != null)
        {
            vignette.intensity.value = Mathf.Lerp(0.6f, 0.1f, normalized);
        }
    }

    public enum ActionType
    {
        Restraint,
        Defense,
        Neutral,
        Aggression,
        Cruelty
    }
}
