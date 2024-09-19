// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d921d2ae-5733-42c5-aa8f-6a13914625d4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a67649a7-b3d2-4889-ab33-38cdca46e287"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""5e14e7d8-0fc0-4040-9919-6873988670e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""eeac5b72-5f5f-4165-8ce9-c2b965cbd3c1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a2a2dd5e-acd3-41a3-bb84-3a25656058f4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""319f91dd-36f9-49a4-8169-28c8a564dd4d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a62794fd-42b9-4818-b57c-dce34a730655"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f438c9c5-8bcd-46c9-8958-3945d404cb46"",
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
                    ""id"": ""e5b18e9f-5fb4-41aa-893e-b227efd8d0bd"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SwitchPlayer"",
            ""id"": ""6ab43bf5-6c1e-4220-8d69-15479edffac6"",
            ""actions"": [
                {
                    ""name"": ""Transparency"",
                    ""type"": ""Button"",
                    ""id"": ""a7f6b47d-dc91-4abd-b1fc-bd4cf7030519"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4c645e3-414e-433f-89c0-4cb31242afe6"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Transparency"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""3a99cdd5-985e-4a7e-b46c-df02166929f3"",
            ""actions"": [
                {
                    ""name"": ""RotateR"",
                    ""type"": ""Button"",
                    ""id"": ""e5b10beb-8334-4c40-acbc-a77bf2ec0395"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateL"",
                    ""type"": ""Button"",
                    ""id"": ""f761cf25-8f65-41f3-803a-bd55a9a25920"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""410b3003-6c92-4c14-b797-8091d14cea3c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""742dd2a2-d079-4377-a054-dff97bfdbf32"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_SwitchCharacter = m_Player.FindAction("SwitchCharacter", throwIfNotFound: true);
        // SwitchPlayer
        m_SwitchPlayer = asset.FindActionMap("SwitchPlayer", throwIfNotFound: true);
        m_SwitchPlayer_Transparency = m_SwitchPlayer.FindAction("Transparency", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_RotateR = m_Camera.FindAction("RotateR", throwIfNotFound: true);
        m_Camera_RotateL = m_Camera.FindAction("RotateL", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_SwitchCharacter;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @SwitchCharacter => m_Wrapper.m_Player_SwitchCharacter;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @SwitchCharacter.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchCharacter;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @SwitchCharacter.started += instance.OnSwitchCharacter;
                @SwitchCharacter.performed += instance.OnSwitchCharacter;
                @SwitchCharacter.canceled += instance.OnSwitchCharacter;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // SwitchPlayer
    private readonly InputActionMap m_SwitchPlayer;
    private ISwitchPlayerActions m_SwitchPlayerActionsCallbackInterface;
    private readonly InputAction m_SwitchPlayer_Transparency;
    public struct SwitchPlayerActions
    {
        private @InputMaster m_Wrapper;
        public SwitchPlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Transparency => m_Wrapper.m_SwitchPlayer_Transparency;
        public InputActionMap Get() { return m_Wrapper.m_SwitchPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SwitchPlayerActions set) { return set.Get(); }
        public void SetCallbacks(ISwitchPlayerActions instance)
        {
            if (m_Wrapper.m_SwitchPlayerActionsCallbackInterface != null)
            {
                @Transparency.started -= m_Wrapper.m_SwitchPlayerActionsCallbackInterface.OnTransparency;
                @Transparency.performed -= m_Wrapper.m_SwitchPlayerActionsCallbackInterface.OnTransparency;
                @Transparency.canceled -= m_Wrapper.m_SwitchPlayerActionsCallbackInterface.OnTransparency;
            }
            m_Wrapper.m_SwitchPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Transparency.started += instance.OnTransparency;
                @Transparency.performed += instance.OnTransparency;
                @Transparency.canceled += instance.OnTransparency;
            }
        }
    }
    public SwitchPlayerActions @SwitchPlayer => new SwitchPlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_RotateR;
    private readonly InputAction m_Camera_RotateL;
    public struct CameraActions
    {
        private @InputMaster m_Wrapper;
        public CameraActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateR => m_Wrapper.m_Camera_RotateR;
        public InputAction @RotateL => m_Wrapper.m_Camera_RotateL;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @RotateR.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateR;
                @RotateR.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateR;
                @RotateR.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateR;
                @RotateL.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateL;
                @RotateL.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateL;
                @RotateL.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateL;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateR.started += instance.OnRotateR;
                @RotateR.performed += instance.OnRotateR;
                @RotateR.canceled += instance.OnRotateR;
                @RotateL.started += instance.OnRotateL;
                @RotateL.performed += instance.OnRotateL;
                @RotateL.canceled += instance.OnRotateL;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSwitchCharacter(InputAction.CallbackContext context);
    }
    public interface ISwitchPlayerActions
    {
        void OnTransparency(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnRotateR(InputAction.CallbackContext context);
        void OnRotateL(InputAction.CallbackContext context);
    }
}
