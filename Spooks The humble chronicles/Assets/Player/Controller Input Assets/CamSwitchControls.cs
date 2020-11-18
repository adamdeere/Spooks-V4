// GENERATED AUTOMATICALLY FROM 'Assets/Player/Controller Input Assets/CamSwitchControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CamSwitchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CamSwitchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CamSwitchControls"",
    ""maps"": [
        {
            ""name"": ""CamSwitch"",
            ""id"": ""38044a95-2760-4e24-b6d1-8c4b12285c40"",
            ""actions"": [
                {
                    ""name"": ""CamSwitchPress"",
                    ""type"": ""Button"",
                    ""id"": ""dc6d4cc9-d324-4329-bb0c-d9b476c99c6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2fe0cf93-6e8e-4494-a336-fa7f28934ad0"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamSwitchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CamSwitch
        m_CamSwitch = asset.FindActionMap("CamSwitch", throwIfNotFound: true);
        m_CamSwitch_CamSwitchPress = m_CamSwitch.FindAction("CamSwitchPress", throwIfNotFound: true);
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

    // CamSwitch
    private readonly InputActionMap m_CamSwitch;
    private ICamSwitchActions m_CamSwitchActionsCallbackInterface;
    private readonly InputAction m_CamSwitch_CamSwitchPress;
    public struct CamSwitchActions
    {
        private @CamSwitchControls m_Wrapper;
        public CamSwitchActions(@CamSwitchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CamSwitchPress => m_Wrapper.m_CamSwitch_CamSwitchPress;
        public InputActionMap Get() { return m_Wrapper.m_CamSwitch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamSwitchActions set) { return set.Get(); }
        public void SetCallbacks(ICamSwitchActions instance)
        {
            if (m_Wrapper.m_CamSwitchActionsCallbackInterface != null)
            {
                @CamSwitchPress.started -= m_Wrapper.m_CamSwitchActionsCallbackInterface.OnCamSwitchPress;
                @CamSwitchPress.performed -= m_Wrapper.m_CamSwitchActionsCallbackInterface.OnCamSwitchPress;
                @CamSwitchPress.canceled -= m_Wrapper.m_CamSwitchActionsCallbackInterface.OnCamSwitchPress;
            }
            m_Wrapper.m_CamSwitchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CamSwitchPress.started += instance.OnCamSwitchPress;
                @CamSwitchPress.performed += instance.OnCamSwitchPress;
                @CamSwitchPress.canceled += instance.OnCamSwitchPress;
            }
        }
    }
    public CamSwitchActions @CamSwitch => new CamSwitchActions(this);
    public interface ICamSwitchActions
    {
        void OnCamSwitchPress(InputAction.CallbackContext context);
    }
}
