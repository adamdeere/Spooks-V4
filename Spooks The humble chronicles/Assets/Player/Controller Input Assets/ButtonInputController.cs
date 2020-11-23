// GENERATED AUTOMATICALLY FROM 'Assets/Player/Controller Input Assets/ButtonInputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ButtonInputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ButtonInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ButtonInputController"",
    ""maps"": [
        {
            ""name"": ""ButtonInput"",
            ""id"": ""da88af49-9f53-4ec8-97bf-42b80e4a8165"",
            ""actions"": [
                {
                    ""name"": ""SquareButton"",
                    ""type"": ""Button"",
                    ""id"": ""63df247c-1424-43a2-81bc-128bfe2531ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CircleButton"",
                    ""type"": ""Button"",
                    ""id"": ""2b1dbf9c-9dc8-43e2-b08a-f5983ee1b349"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriangleButton"",
                    ""type"": ""Button"",
                    ""id"": ""31a1c28d-5269-4854-a3ba-6c264c84ff90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftDpad"",
                    ""type"": ""Button"",
                    ""id"": ""2e44737b-378b-42b5-99bf-13eae6b793a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightDpad"",
                    ""type"": ""Button"",
                    ""id"": ""cca578ad-3ed6-4fb1-8cde-65a163425b5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DownDPad"",
                    ""type"": ""Button"",
                    ""id"": ""10682adb-1306-4764-89ea-ee4c615cae69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDpad"",
                    ""type"": ""Button"",
                    ""id"": ""5582dc47-bd94-4e3c-9eae-a46fb50f7da2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bce4a781-967e-4432-b50e-a149d48f6a75"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SquareButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6463769d-8a7d-4a1f-9999-7dd868601c12"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CircleButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16224d72-3670-4f0a-8bdf-0eea6588d4df"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriangleButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a7c536-2db5-4d4c-8e83-3753ce99e884"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7d0726a-b6c9-4135-bc8b-6456a9af0f84"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcd94d66-95f5-475b-b7e0-3235304f5633"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownDPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b035330e-9f4c-49ca-8470-e268e40a00cc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ButtonInput
        m_ButtonInput = asset.FindActionMap("ButtonInput", throwIfNotFound: true);
        m_ButtonInput_SquareButton = m_ButtonInput.FindAction("SquareButton", throwIfNotFound: true);
        m_ButtonInput_CircleButton = m_ButtonInput.FindAction("CircleButton", throwIfNotFound: true);
        m_ButtonInput_TriangleButton = m_ButtonInput.FindAction("TriangleButton", throwIfNotFound: true);
        m_ButtonInput_LeftDpad = m_ButtonInput.FindAction("LeftDpad", throwIfNotFound: true);
        m_ButtonInput_RightDpad = m_ButtonInput.FindAction("RightDpad", throwIfNotFound: true);
        m_ButtonInput_DownDPad = m_ButtonInput.FindAction("DownDPad", throwIfNotFound: true);
        m_ButtonInput_UpDpad = m_ButtonInput.FindAction("UpDpad", throwIfNotFound: true);
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

    // ButtonInput
    private readonly InputActionMap m_ButtonInput;
    private IButtonInputActions m_ButtonInputActionsCallbackInterface;
    private readonly InputAction m_ButtonInput_SquareButton;
    private readonly InputAction m_ButtonInput_CircleButton;
    private readonly InputAction m_ButtonInput_TriangleButton;
    private readonly InputAction m_ButtonInput_LeftDpad;
    private readonly InputAction m_ButtonInput_RightDpad;
    private readonly InputAction m_ButtonInput_DownDPad;
    private readonly InputAction m_ButtonInput_UpDpad;
    public struct ButtonInputActions
    {
        private @ButtonInputController m_Wrapper;
        public ButtonInputActions(@ButtonInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @SquareButton => m_Wrapper.m_ButtonInput_SquareButton;
        public InputAction @CircleButton => m_Wrapper.m_ButtonInput_CircleButton;
        public InputAction @TriangleButton => m_Wrapper.m_ButtonInput_TriangleButton;
        public InputAction @LeftDpad => m_Wrapper.m_ButtonInput_LeftDpad;
        public InputAction @RightDpad => m_Wrapper.m_ButtonInput_RightDpad;
        public InputAction @DownDPad => m_Wrapper.m_ButtonInput_DownDPad;
        public InputAction @UpDpad => m_Wrapper.m_ButtonInput_UpDpad;
        public InputActionMap Get() { return m_Wrapper.m_ButtonInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ButtonInputActions set) { return set.Get(); }
        public void SetCallbacks(IButtonInputActions instance)
        {
            if (m_Wrapper.m_ButtonInputActionsCallbackInterface != null)
            {
                @SquareButton.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnSquareButton;
                @SquareButton.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnSquareButton;
                @SquareButton.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnSquareButton;
                @CircleButton.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnCircleButton;
                @CircleButton.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnCircleButton;
                @CircleButton.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnCircleButton;
                @TriangleButton.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnTriangleButton;
                @TriangleButton.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnTriangleButton;
                @TriangleButton.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnTriangleButton;
                @LeftDpad.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnLeftDpad;
                @LeftDpad.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnLeftDpad;
                @LeftDpad.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnLeftDpad;
                @RightDpad.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnRightDpad;
                @RightDpad.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnRightDpad;
                @RightDpad.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnRightDpad;
                @DownDPad.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnDownDPad;
                @DownDPad.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnDownDPad;
                @DownDPad.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnDownDPad;
                @UpDpad.started -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnUpDpad;
                @UpDpad.performed -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnUpDpad;
                @UpDpad.canceled -= m_Wrapper.m_ButtonInputActionsCallbackInterface.OnUpDpad;
            }
            m_Wrapper.m_ButtonInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SquareButton.started += instance.OnSquareButton;
                @SquareButton.performed += instance.OnSquareButton;
                @SquareButton.canceled += instance.OnSquareButton;
                @CircleButton.started += instance.OnCircleButton;
                @CircleButton.performed += instance.OnCircleButton;
                @CircleButton.canceled += instance.OnCircleButton;
                @TriangleButton.started += instance.OnTriangleButton;
                @TriangleButton.performed += instance.OnTriangleButton;
                @TriangleButton.canceled += instance.OnTriangleButton;
                @LeftDpad.started += instance.OnLeftDpad;
                @LeftDpad.performed += instance.OnLeftDpad;
                @LeftDpad.canceled += instance.OnLeftDpad;
                @RightDpad.started += instance.OnRightDpad;
                @RightDpad.performed += instance.OnRightDpad;
                @RightDpad.canceled += instance.OnRightDpad;
                @DownDPad.started += instance.OnDownDPad;
                @DownDPad.performed += instance.OnDownDPad;
                @DownDPad.canceled += instance.OnDownDPad;
                @UpDpad.started += instance.OnUpDpad;
                @UpDpad.performed += instance.OnUpDpad;
                @UpDpad.canceled += instance.OnUpDpad;
            }
        }
    }
    public ButtonInputActions @ButtonInput => new ButtonInputActions(this);
    public interface IButtonInputActions
    {
        void OnSquareButton(InputAction.CallbackContext context);
        void OnCircleButton(InputAction.CallbackContext context);
        void OnTriangleButton(InputAction.CallbackContext context);
        void OnLeftDpad(InputAction.CallbackContext context);
        void OnRightDpad(InputAction.CallbackContext context);
        void OnDownDPad(InputAction.CallbackContext context);
        void OnUpDpad(InputAction.CallbackContext context);
    }
}
