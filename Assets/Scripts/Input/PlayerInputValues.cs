using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputValues
{
    private GameInputs inputActions;

    public PlayerInputValues()
    {
        Init();  
    }

    private void Init()
    {
        inputActions = new GameInputs();
        inputActions.devices = new[] { Gamepad.all[0] };
        inputActions.devices = new[] { Keyboard.current};
        inputActions.Enable();
    }

    public void AssignInput(IGameplayInputListener listener)
    {
        inputActions.Gameplay.Move.performed += listener.OnMovement;
        inputActions.Gameplay.Move.canceled += listener.OnMovement;
        inputActions.Gameplay.Shoot.performed += listener.OnFire;
        inputActions.Gameplay.Shoot.canceled += listener.OnFire;
        inputActions.Gameplay.Rotate.performed += listener.OnRotate;
        inputActions.Gameplay.Rotate.canceled += listener.OnRotate;
    }

    public void RemoveInput(IGameplayInputListener listener)
    {
        inputActions.Gameplay.Move.performed -= listener.OnMovement;
        inputActions.Gameplay.Move.canceled -= listener.OnMovement;
        inputActions.Gameplay.Shoot.performed -= listener.OnFire;
        inputActions.Gameplay.Shoot.canceled -= listener.OnFire;
        inputActions.Gameplay.Rotate.performed -= listener.OnRotate;
        inputActions.Gameplay.Rotate.canceled -= listener.OnRotate;
    }
}