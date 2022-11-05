using UnityEngine;

public class PanZoom : MonoBehaviour
{
    private const int MAGIC_WIDTH_NUMBER = 64;
    private const int MAGIC_HEIGHT_NUMBER = 320;

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

        Zoom(Input.GetAxis("Mouse ScrollWheel"));
    }

    private void Zoom(float increment)
    {
        Rect uiRect = UIRect.rect;
        float uiRectWidth = uiRect.width;
        float uiRectHeight = uiRect.height;
        UIRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, uiRectWidth + MAGIC_WIDTH_NUMBER * increment);
        UIRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, uiRectHeight + MAGIC_HEIGHT_NUMBER * increment);
        
        foreach (RectTransform rectTransform in ButtonRectList)
        {
            Rect buttonRect = rectTransform.rect;
            float widthRatio = buttonRect.width / uiRectWidth;
            float heightRatio = buttonRect.height / uiRectHeight;
            float deltaWidth = MAGIC_WIDTH_NUMBER * widthRatio * increment;
            float deltaHeight = MAGIC_HEIGHT_NUMBER * heightRatio * increment;
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, buttonRect.width + deltaWidth);
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, buttonRect.height + deltaHeight);

            Vector2 anchoredPosition = rectTransform.anchoredPosition;
            const float magicScaleNumber = 5.5f;
            Vector2 newPosition = new Vector2(anchoredPosition.x, anchoredPosition.y + deltaHeight * magicScaleNumber);
            anchoredPosition = newPosition;
            rectTransform.anchoredPosition = anchoredPosition;
        }
        
    }
}
