using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;

    private HeroInputActions _inputActions;

    private void Awake()
    {
        _inputActions = new HeroInputActions();
        _inputActions.Hero.Movement.performed += Movement;
        _inputActions.Hero.Movement.canceled += Movement;

        _inputActions.Hero.SaySomething.performed += SaySomething;
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }

    private void Movement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        _hero.SetDirection(direction);
    }

    private void SaySomething(InputAction.CallbackContext context)
    {
        _hero.SaySomething();
    }
}
