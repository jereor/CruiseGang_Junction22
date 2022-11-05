using System.Collections;
using UnityEngine;

public class PinchDetection : MonoBehaviour
{
    [SerializeField] private float _zoomModifier = 4f;
    [SerializeField] private RectTransform _mapImage;
    
    private TouchControls _controls;
    private Coroutine _zoomCoroutine;

    private void Awake()
    {
        _controls = new TouchControls();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Start()
    {
        _controls.Touch.SecondaryFingerContact.started += _ => ZoomStart();
        _controls.Touch.SecondaryFingerContact.canceled += _ => ZoomEnd();
        _controls.Touch.PrimaryFingerContact.canceled += _ => ZoomEnd();
    }
    
    private void ZoomStart()
    {
        _zoomCoroutine = StartCoroutine(ZoomDetection());
    }
    
    private void ZoomEnd()
    {
        StopCoroutine(_zoomCoroutine);
    }

    IEnumerator ZoomDetection()
    {
        float timer = 0f;
        float previousDistance = 0f;

        while (true)
        {
            float distance = Vector2.Distance(_controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(), 
                _controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());

            float width = _mapImage.rect.width;
            float height = _mapImage.rect.height;
            float ratio = width / height;
            
            if (distance > previousDistance)
            {
                _mapImage.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width + _zoomModifier * ratio);
                _mapImage.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height + _zoomModifier);
            }
            else if (distance < previousDistance)
            {
                _mapImage.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width - _zoomModifier * ratio);
                _mapImage.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height - _zoomModifier);
            }

            previousDistance = distance;

            timer += Time.deltaTime;
            yield return null;
        }
    }
}
