using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
/**********************************************************************************************************************
* Project: First Blood
* File   : PlayerInput.cs
* Date   : 07.01.22
* Author : Nevruz Tuerk
*
* These coded instructions, statements, and computer programs contain
* proprietary information of the author and are protected by Federal
* copyright law. They may not be disclosed to third parties or copied
* or duplicated in any form, in whole or in part, without the prior
* written consent of the author.
*
* History:
*	07.01.22	NT	Generated
**********************************************************************************************************************/
public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b130b77f-d6a5-4b8a-8317-22d0d44e2d07"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a5310e81-94bb-427a-a973-c3aebce90cfb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""xButton"",
                    ""type"": ""Button"",
                    ""id"": ""c3f7e70f-11a7-4a8d-9a2c-5ac2c290a409"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""bButton"",
                    ""type"": ""Button"",
                    ""id"": ""ed2d5bad-743d-438b-9e88-963db0574ff2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ltTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""04b21236-8da9-4895-aecc-48fbfe527315"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""rtTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""6a2b7912-eeb7-4a66-866e-405b9d3e5248"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bbfa17cf-0374-465b-b994-1d9d7cb5d6be"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""xButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c1f5e76-f597-45a9-821a-bd2674c45d54"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""xButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""108621e9-c59a-41f2-9be2-6c41a356692b"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""bButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""433d3d6c-f920-45f2-a663-98f53d48dd81"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""bButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""864e73f8-8c1f-40a3-95de-7325ea29a477"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""44031b88-8c99-4cf5-9d3c-d2699d9a3f70"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec387202-6e06-4ec8-9750-b9d0c967c97f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d0a07e4f-bf2a-4234-b773-26e64995a43c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6bafeefb-244b-4398-a153-1132a7082267"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""006c62af-e175-4f75-bcd5-c766cb2e5807"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Dash"",
                    ""id"": ""b4188712-741c-475c-83f5-afdf9fbba714"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ltTrigger"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""78262ad8-2d59-446b-afcc-1c27c8237969"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ltTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0fd9c622-8903-486c-9627-5e17462c3d33"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ltTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Dash"",
                    ""id"": ""d97a3cca-888e-48f5-a329-e1ac0f81c53d"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rtTrigger"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""06f0229b-540e-4fb2-b1eb-8c753d1e46ae"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""rtTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""c3feac10-fc7a-4a51-9894-43557bed3f85"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""rtTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_xButton = m_Player.FindAction("xButton", throwIfNotFound: true);
        m_Player_bButton = m_Player.FindAction("bButton", throwIfNotFound: true);
        m_Player_ltTrigger = m_Player.FindAction("ltTrigger", throwIfNotFound: true);
        m_Player_rtTrigger = m_Player.FindAction("rtTrigger", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_xButton;
    private readonly InputAction m_Player_bButton;
    private readonly InputAction m_Player_ltTrigger;
    private readonly InputAction m_Player_rtTrigger;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @xButton => m_Wrapper.m_Player_xButton;
        public InputAction @bButton => m_Wrapper.m_Player_bButton;
        public InputAction @ltTrigger => m_Wrapper.m_Player_ltTrigger;
        public InputAction @rtTrigger => m_Wrapper.m_Player_rtTrigger;
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
                @xButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXButton;
                @xButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXButton;
                @xButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXButton;
                @bButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBButton;
                @bButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBButton;
                @bButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBButton;
                @ltTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLtTrigger;
                @ltTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLtTrigger;
                @ltTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLtTrigger;
                @rtTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRtTrigger;
                @rtTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRtTrigger;
                @rtTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRtTrigger;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @xButton.started += instance.OnXButton;
                @xButton.performed += instance.OnXButton;
                @xButton.canceled += instance.OnXButton;
                @bButton.started += instance.OnBButton;
                @bButton.performed += instance.OnBButton;
                @bButton.canceled += instance.OnBButton;
                @ltTrigger.started += instance.OnLtTrigger;
                @ltTrigger.performed += instance.OnLtTrigger;
                @ltTrigger.canceled += instance.OnLtTrigger;
                @rtTrigger.started += instance.OnRtTrigger;
                @rtTrigger.performed += instance.OnRtTrigger;
                @rtTrigger.canceled += instance.OnRtTrigger;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnXButton(InputAction.CallbackContext context);
        void OnBButton(InputAction.CallbackContext context);
        void OnLtTrigger(InputAction.CallbackContext context);
        void OnRtTrigger(InputAction.CallbackContext context);
    }
}
