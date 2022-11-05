using UnityEngine;

public class PanZoom : MonoBehaviour
{
    private Vector3 _touchStart;

    public RectTransform UIRect;
    public RectTransform[] ButtonRectList;

    private void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            Zoom(difference * 0.01f);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 direction = _touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
        }

        Zoom(Input.GetAxis("Mouse ScrollWheel"));
    }

    private void Zoom(float increment)
    {
        Rect uiRect = UIRect.rect;
        float uiRectWidth = uiRect.width;
        float uiRectHeight = uiRect.height;
        UIRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, uiRectWidth + 64 * increment);
        UIRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, uiRectHeight + 320 * increment);
        
        foreach (RectTransform rectTransform in ButtonRectList)
        {
            Rect buttonRect = rectTransform.rect;
            float widthRatio = buttonRect.width / uiRectWidth;
            float heightRatio = buttonRect.height / uiRectHeight;
            float deltaWidth = 64 * widthRatio * increment;
            float deltaHeight = 320 * heightRatio * increment;
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, buttonRect.width + deltaWidth);
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, buttonRect.height + deltaHeight);

            Vector2 anchoredPosition = rectTransform.anchoredPosition;
            Vector2 newPosition = new Vector2(anchoredPosition.x, anchoredPosition.y + deltaHeight * 5.5f);
            anchoredPosition = newPosition;
            rectTransform.anchoredPosition = anchoredPosition;
        }
        
    }
}
