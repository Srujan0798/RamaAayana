using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private PlayerController activePlayer;

    void Update()
    {
        if (activePlayer == null)
        {
            return;
        }

        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 look = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        bool actionPressed = Input.GetButtonDown("Fire1");
        bool actionHeld = Input.GetButton("Fire1");

        activePlayer.ProcessMovement(move);
        activePlayer.ProcessCamera(look);
        activePlayer.ProcessAction(actionPressed, actionHeld);
    }

    public void SetActivePlayer(PlayerController controller)
    {
        activePlayer = controller;
    }
}
