//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/UserInput/HeroInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @HeroInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @HeroInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HeroInputActions"",
    ""maps"": [
        {
            ""name"": ""Hero"",
            ""id"": ""a7a59a8e-07f3-4e3d-aae4-d35637c1be19"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""61ba0e6d-572f-4fa3-ab36-8fb0a1831ead"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SaySomething"",
                    ""type"": ""Button"",
                    ""id"": ""9233a77f-2fcc-4884-af2a-0785b2edd904"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c41ae270-c112-4914-85bf-84bb3fa23a5b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""977df5af-449b-4459-a4ad-339689117158"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""73c0e0fa-7b34-470e-a88c-3700189cd314"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""4fcc171a-dcaf-4b0a-8564-beda45e0491c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""dd6a7358-0304-4dcd-aca2-01ceea6a4bb5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""65ae5be6-8362-4e82-a5b1-c4adfcf8630f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SaySomething"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85890abb-8772-4aa1-9ebe-ba0c81a0ed59"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SaySomething"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Hero
        m_Hero = asset.FindActionMap("Hero", throwIfNotFound: true);
        m_Hero_Movement = m_Hero.FindAction("Movement", throwIfNotFound: true);
        m_Hero_SaySomething = m_Hero.FindAction("SaySomething", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Hero
    private readonly InputActionMap m_Hero;
    private List<IHeroActions> m_HeroActionsCallbackInterfaces = new List<IHeroActions>();
    private readonly InputAction m_Hero_Movement;
    private readonly InputAction m_Hero_SaySomething;
    public struct HeroActions
    {
        private @HeroInputActions m_Wrapper;
        public HeroActions(@HeroInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Hero_Movement;
        public InputAction @SaySomething => m_Wrapper.m_Hero_SaySomething;
        public InputActionMap Get() { return m_Wrapper.m_Hero; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeroActions set) { return set.Get(); }
        public void AddCallbacks(IHeroActions instance)
        {
            if (instance == null || m_Wrapper.m_HeroActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HeroActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @SaySomething.started += instance.OnSaySomething;
            @SaySomething.performed += instance.OnSaySomething;
            @SaySomething.canceled += instance.OnSaySomething;
        }

        private void UnregisterCallbacks(IHeroActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @SaySomething.started -= instance.OnSaySomething;
            @SaySomething.performed -= instance.OnSaySomething;
            @SaySomething.canceled -= instance.OnSaySomething;
        }

        public void RemoveCallbacks(IHeroActions instance)
        {
            if (m_Wrapper.m_HeroActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHeroActions instance)
        {
            foreach (var item in m_Wrapper.m_HeroActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HeroActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HeroActions @Hero => new HeroActions(this);
    public interface IHeroActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSaySomething(InputAction.CallbackContext context);
    }
}