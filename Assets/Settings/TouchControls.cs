// GENERATED AUTOMATICALLY FROM 'Assets/Settings/TouchControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""9c8b351c-8d12-4961-af65-8eda00be21cd"",
            ""actions"": [
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""08714f1b-865f-468f-915d-a689cd6da620"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""d752163a-9237-42a0-a77c-2679422605e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Finger Contact"",
                    ""type"": ""Button"",
                    ""id"": ""5227e7e3-68f0-41e5-b01d-a50fc86a4db2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Primary Finger Contact"",
                    ""type"": ""Button"",
                    ""id"": ""be971135-cd0b-4a3b-94e3-0c0fffe3871f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa3874dd-09eb-40b3-8da9-2cfed9efff2b"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6c56f78-a22b-455b-b678-18c72701a25e"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b47cc6a-f2a0-432f-9782-de4588a6ec80"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Finger Contact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b90bd88b-4ba5-400d-8ddf-762b42a4758e"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Contact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryFingerPosition = m_Touch.FindAction("Primary Finger Position", throwIfNotFound: true);
        m_Touch_SecondaryFingerPosition = m_Touch.FindAction("Secondary Finger Position", throwIfNotFound: true);
        m_Touch_SecondaryFingerContact = m_Touch.FindAction("Secondary Finger Contact", throwIfNotFound: true);
        m_Touch_PrimaryFingerContact = m_Touch.FindAction("Primary Finger Contact", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_PrimaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryFingerContact;
    private readonly InputAction m_Touch_PrimaryFingerContact;
    public struct TouchActions
    {
        private @TouchControls m_Wrapper;
        public TouchActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Touch_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Touch_SecondaryFingerPosition;
        public InputAction @SecondaryFingerContact => m_Wrapper.m_Touch_SecondaryFingerContact;
        public InputAction @PrimaryFingerContact => m_Wrapper.m_Touch_PrimaryFingerContact;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerContact;
                @SecondaryFingerContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerContact;
                @SecondaryFingerContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerContact;
                @PrimaryFingerContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerContact;
                @PrimaryFingerContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerContact;
                @PrimaryFingerContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerContact;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
                @SecondaryFingerContact.started += instance.OnSecondaryFingerContact;
                @SecondaryFingerContact.performed += instance.OnSecondaryFingerContact;
                @SecondaryFingerContact.canceled += instance.OnSecondaryFingerContact;
                @PrimaryFingerContact.started += instance.OnPrimaryFingerContact;
                @PrimaryFingerContact.performed += instance.OnPrimaryFingerContact;
                @PrimaryFingerContact.canceled += instance.OnPrimaryFingerContact;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerContact(InputAction.CallbackContext context);
        void OnPrimaryFingerContact(InputAction.CallbackContext context);
    }
}
