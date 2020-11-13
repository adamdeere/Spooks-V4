// GENERATED AUTOMATICALLY FROM 'Assets/Input Assets/MotionInputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MotionInputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MotionInputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MotionInputControls"",
    ""maps"": [
        {
            ""name"": ""MotionControls"",
            ""id"": ""b8fbac4e-80d6-4c8d-b712-724f589c1a18"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""db31c4f8-d19d-4b8c-b3c2-80cd21977ea3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""9072e729-52de-46fe-a94e-bd2c949ad502"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6780c31-784b-478c-8b08-8f48d5144002"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b63d6fec-fdb8-4143-a640-acda60a0cfa5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MotionControls
        m_MotionControls = asset.FindActionMap("MotionControls", throwIfNotFound: true);
        m_MotionControls_Move = m_MotionControls.FindAction("Move", throwIfNotFound: true);
        m_MotionControls_Camera = m_MotionControls.FindAction("Camera", throwIfNotFound: true);
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

    // MotionControls
    private readonly InputActionMap m_MotionControls;
    private IMotionControlsActions m_MotionControlsActionsCallbackInterface;
    private readonly InputAction m_MotionControls_Move;
    private readonly InputAction m_MotionControls_Camera;
    public struct MotionControlsActions
    {
        private @MotionInputControls m_Wrapper;
        public MotionControlsActions(@MotionInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MotionControls_Move;
        public InputAction @Camera => m_Wrapper.m_MotionControls_Camera;
        public InputActionMap Get() { return m_Wrapper.m_MotionControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MotionControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMotionControlsActions instance)
        {
            if (m_Wrapper.m_MotionControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnMove;
                @Camera.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_MotionControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public MotionControlsActions @MotionControls => new MotionControlsActions(this);
    public interface IMotionControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
}
