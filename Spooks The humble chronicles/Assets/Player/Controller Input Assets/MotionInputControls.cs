// GENERATED AUTOMATICALLY FROM 'Assets/Player/Controller Input Assets/MotionInputControls.inputactions'

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
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""9072e729-52de-46fe-a94e-bd2c949ad502"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0ece5b97-f03b-4f1f-9b44-b5b92eb60c9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightSwing"",
                    ""type"": ""Button"",
                    ""id"": ""71de460a-2a84-4312-b1a3-047471c42a09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavySwing"",
                    ""type"": ""Button"",
                    ""id"": ""9f499d64-fc76-42c3-9156-908d2bbe925e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fireball"",
                    ""type"": ""Button"",
                    ""id"": ""876b195e-cd21-45a5-831f-7e52fcfd7a7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavySpellOne"",
                    ""type"": ""Button"",
                    ""id"": ""213b7409-1420-4400-99b0-da377763abb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavySpellTwo"",
                    ""type"": ""Button"",
                    ""id"": ""8115d8c7-db4a-4ce3-a6fc-2ed6b6fdb31a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SheaveSword"",
                    ""type"": ""Button"",
                    ""id"": ""d5fc9dee-8b10-40d9-96bd-ea5a8c91fbbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SheaveShield"",
                    ""type"": ""Button"",
                    ""id"": ""96b14adc-b9dc-42e4-8f2e-4d1771c514c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""363936e6-41e1-4477-ab78-2dd347a88c5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""af4c8e17-7bd7-4fe1-8d41-0c022ee88b72"",
                    ""expectedControlType"": ""Button"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""f9b84375-2e8a-404f-a754-cee3c44db9b1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dec81545-7f4d-44b8-ab35-2c92d44744a0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightSwing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f5d34c3-fdb9-40bc-93a9-9522c5f3ea70"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavySwing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a40987a5-17e8-4d71-80b6-4a0c6bf1c679"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fireball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09d7b189-5e05-4f9d-83ed-b28570e6b14b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavySpellOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef2cf490-9f32-42c7-a73f-78800ed37fb4"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavySpellTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6690430-188e-4df7-a7a3-c7f847ed4dc6"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SheaveSword"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26493e36-3e51-4bb6-8d8e-0ca0343cf388"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SheaveShield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a501f79-9480-414e-9253-d83c98371f2d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78f7c61d-572e-4e47-9e04-dc7d4451a521"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
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
        m_MotionControls_Jump = m_MotionControls.FindAction("Jump", throwIfNotFound: true);
        m_MotionControls_LightSwing = m_MotionControls.FindAction("LightSwing", throwIfNotFound: true);
        m_MotionControls_HeavySwing = m_MotionControls.FindAction("HeavySwing", throwIfNotFound: true);
        m_MotionControls_Fireball = m_MotionControls.FindAction("Fireball", throwIfNotFound: true);
        m_MotionControls_HeavySpellOne = m_MotionControls.FindAction("HeavySpellOne", throwIfNotFound: true);
        m_MotionControls_HeavySpellTwo = m_MotionControls.FindAction("HeavySpellTwo", throwIfNotFound: true);
        m_MotionControls_SheaveSword = m_MotionControls.FindAction("SheaveSword", throwIfNotFound: true);
        m_MotionControls_SheaveShield = m_MotionControls.FindAction("SheaveShield", throwIfNotFound: true);
        m_MotionControls_Block = m_MotionControls.FindAction("Block", throwIfNotFound: true);
        m_MotionControls_Run = m_MotionControls.FindAction("Run", throwIfNotFound: true);
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
    private readonly InputAction m_MotionControls_Jump;
    private readonly InputAction m_MotionControls_LightSwing;
    private readonly InputAction m_MotionControls_HeavySwing;
    private readonly InputAction m_MotionControls_Fireball;
    private readonly InputAction m_MotionControls_HeavySpellOne;
    private readonly InputAction m_MotionControls_HeavySpellTwo;
    private readonly InputAction m_MotionControls_SheaveSword;
    private readonly InputAction m_MotionControls_SheaveShield;
    private readonly InputAction m_MotionControls_Block;
    private readonly InputAction m_MotionControls_Run;
    public struct MotionControlsActions
    {
        private @MotionInputControls m_Wrapper;
        public MotionControlsActions(@MotionInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MotionControls_Move;
        public InputAction @Camera => m_Wrapper.m_MotionControls_Camera;
        public InputAction @Jump => m_Wrapper.m_MotionControls_Jump;
        public InputAction @LightSwing => m_Wrapper.m_MotionControls_LightSwing;
        public InputAction @HeavySwing => m_Wrapper.m_MotionControls_HeavySwing;
        public InputAction @Fireball => m_Wrapper.m_MotionControls_Fireball;
        public InputAction @HeavySpellOne => m_Wrapper.m_MotionControls_HeavySpellOne;
        public InputAction @HeavySpellTwo => m_Wrapper.m_MotionControls_HeavySpellTwo;
        public InputAction @SheaveSword => m_Wrapper.m_MotionControls_SheaveSword;
        public InputAction @SheaveShield => m_Wrapper.m_MotionControls_SheaveShield;
        public InputAction @Block => m_Wrapper.m_MotionControls_Block;
        public InputAction @Run => m_Wrapper.m_MotionControls_Run;
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
                @Jump.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnJump;
                @LightSwing.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnLightSwing;
                @LightSwing.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnLightSwing;
                @LightSwing.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnLightSwing;
                @HeavySwing.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySwing;
                @HeavySwing.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySwing;
                @HeavySwing.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySwing;
                @Fireball.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnFireball;
                @Fireball.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnFireball;
                @Fireball.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnFireball;
                @HeavySpellOne.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySpellOne;
                @HeavySpellOne.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySpellOne;
                @HeavySpellOne.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySpellOne;
                @HeavySpellTwo.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySpellTwo;
                @HeavySpellTwo.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySpellTwo;
                @HeavySpellTwo.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnHeavySpellTwo;
                @SheaveSword.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnSheaveSword;
                @SheaveSword.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnSheaveSword;
                @SheaveSword.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnSheaveSword;
                @SheaveShield.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnSheaveShield;
                @SheaveShield.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnSheaveShield;
                @SheaveShield.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnSheaveShield;
                @Block.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnBlock;
                @Run.started -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MotionControlsActionsCallbackInterface.OnRun;
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
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LightSwing.started += instance.OnLightSwing;
                @LightSwing.performed += instance.OnLightSwing;
                @LightSwing.canceled += instance.OnLightSwing;
                @HeavySwing.started += instance.OnHeavySwing;
                @HeavySwing.performed += instance.OnHeavySwing;
                @HeavySwing.canceled += instance.OnHeavySwing;
                @Fireball.started += instance.OnFireball;
                @Fireball.performed += instance.OnFireball;
                @Fireball.canceled += instance.OnFireball;
                @HeavySpellOne.started += instance.OnHeavySpellOne;
                @HeavySpellOne.performed += instance.OnHeavySpellOne;
                @HeavySpellOne.canceled += instance.OnHeavySpellOne;
                @HeavySpellTwo.started += instance.OnHeavySpellTwo;
                @HeavySpellTwo.performed += instance.OnHeavySpellTwo;
                @HeavySpellTwo.canceled += instance.OnHeavySpellTwo;
                @SheaveSword.started += instance.OnSheaveSword;
                @SheaveSword.performed += instance.OnSheaveSword;
                @SheaveSword.canceled += instance.OnSheaveSword;
                @SheaveShield.started += instance.OnSheaveShield;
                @SheaveShield.performed += instance.OnSheaveShield;
                @SheaveShield.canceled += instance.OnSheaveShield;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public MotionControlsActions @MotionControls => new MotionControlsActions(this);
    public interface IMotionControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLightSwing(InputAction.CallbackContext context);
        void OnHeavySwing(InputAction.CallbackContext context);
        void OnFireball(InputAction.CallbackContext context);
        void OnHeavySpellOne(InputAction.CallbackContext context);
        void OnHeavySpellTwo(InputAction.CallbackContext context);
        void OnSheaveSword(InputAction.CallbackContext context);
        void OnSheaveShield(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
