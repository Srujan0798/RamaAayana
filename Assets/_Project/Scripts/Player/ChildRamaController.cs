using UnityEngine;

public class ChildRamaController : PlayerController
{
    [Header("Child Specific")]
    [SerializeField] private float walkSpeed = 2.5f;

    private CharacterController controller;
    private Camera mainCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        mainCamera = Camera.main;
        Initialize();
        moveSpeed = walkSpeed;
    }

    public override void ProcessMovement(Vector2 input)
    {
        if (isInCinematic) return;

        Vector3 move = new Vector3(input.x, 0f, input.y);
        move = mainCamera.transform.TransformDirection(move);
        move.y = 0f;
        move.Normalize();

        controller.Move(move * moveSpeed * Time.deltaTime);

        if (move.sqrMagnitude > 0.01f)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(move),
                10f * Time.deltaTime
            );
        }
    }

    public override void ProcessAction(bool pressed, bool held)
    {
        if (isInCinematic || !pressed) return;

        if (Physics.Raycast(transform.position + Vector3.up, transform.forward, out RaycastHit hit, 2f))
        {
            var interactable = hit.collider.GetComponent<IInteractable>();
            interactable?.Interact(this);
        }
    }

    public override void ProcessCamera(Vector2 lookInput)
    {
        // Prologue uses a fixed or Cinemachine-driven camera.
    }
}
