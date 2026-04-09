using UnityEngine;

public abstract class PlayerController : MonoBehaviour
{
    [Header("Base Stats")]
    [SerializeField] protected float maxStamina = 100f;
    [SerializeField] protected float moveSpeed = 5f;

    protected float currentStamina;
    protected bool isInCinematic;

    public virtual void Initialize()
    {
        currentStamina = maxStamina;
        isInCinematic = false;
    }

    public abstract void ProcessMovement(Vector2 input);
    public abstract void ProcessAction(bool pressed, bool held);
    public abstract void ProcessCamera(Vector2 lookInput);

    protected void UpdateStamina(float delta)
    {
        currentStamina = Mathf.Clamp(currentStamina + delta, 0f, maxStamina);
        StaminaChanged?.Invoke(currentStamina / maxStamina);
    }

    public event System.Action<float> StaminaChanged;
    public event System.Action<bool> CinematicStateChanged;

    public void SetCinematicState(bool inCinematic)
    {
        isInCinematic = inCinematic;
        CinematicStateChanged?.Invoke(inCinematic);
    }
}
