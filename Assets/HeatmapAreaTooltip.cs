using UnityEngine;
using UnityEngine.EventSystems;

public class HeatmapAreaTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject TooltipWindow;

    private void Start()
    {
        TooltipWindowSetActive(false);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipWindowSetActive(true);
        TooltipWindowSetPosition(eventData.position);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipWindowSetActive(false);
    }
    
    
    
    private void TooltipWindowSetActive(bool active)
    {
        if (TooltipWindow == null)
        {
            return;
        }

        TooltipWindow.SetActive(active);
    }

    private void TooltipWindowSetPosition(Vector2 position)
    {
        TooltipWindow.transform.position = position;
    }
    
}
