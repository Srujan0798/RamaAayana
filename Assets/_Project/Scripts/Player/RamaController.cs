using UnityEngine;

public class RamaController : PlayerController
{
    [Header("Rama Movement")]
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float staminaRegenPerSecond = 8f;
    [SerializeField] private float dodgeStaminaCost = 15f;

    private CharacterController controller;
    private Camera mainCamera;
    private bool isAiming;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        mainCamera = Camera.main;
        Initialize();
    }

    void Update()
    {
        if (isInCinematic) return;

        if (!isAiming)
        {
            UpdateStamina(staminaRegenPerSecond * Time.deltaTime);
        }
    }

    public override void ProcessMovement(Vector2 input)
    {
        if (isInCinematic) return;

        Vector3 move = new Vector3(input.x, 0f, input.y);
        if (move.sqrMagnitude <= 0.001f)
        {
            return;
        }

        move = mainCamera.transform.TransformDirection(move);
        move.y = 0f;
        move.Normalize();

        controller.Move(move * moveSpeed * Time.deltaTime);

        Quaternion targetRotation = Quaternion.LookRotation(move);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    public override void ProcessAction(bool pressed, bool held)
    {
        if (isInCinematic) return;

        if (held)
        {
            isAiming = true;
            UpdateStamina(-Time.deltaTime * 10f);
        }
        else
        {
            isAiming = false;
        }

        if (pressed && currentStamina >= dodgeStaminaCost)
        {
            UpdateStamina(-dodgeStaminaCost);
            // Placeholder dodge impulse until animation system is wired.
            Vector3 dodge = transform.forward * 0.5f;
            controller.Move(dodge);
        }
    }

    public override void ProcessCamera(Vector2 lookInput)
    {
        // Camera control expected via Cinemachine; keeping stub for future input routing.
    }
}
