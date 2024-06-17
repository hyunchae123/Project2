using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class joystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Image imageBackground;
    private Image imageController;
    Vector2 touchPosition;

    private void Awake()
    {
        imageBackground = GetComponent<Image>();
        imageController = transform.GetChild(0).GetComponent<Image>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        touchPosition = Vector2.zero;

        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(imageBackground.rectTransform, eventData.position, eventData.pressEventCamera, out touchPosition)) 
        {
            touchPosition.x = touchPosition.x / imageBackground.rectTransform.sizeDelta.x;
            touchPosition.y = touchPosition.y / imageBackground.rectTransform.sizeDelta.y;

            touchPosition = (touchPosition.magnitude > 1) ? touchPosition.normalized : touchPosition;
        }

        imageController.rectTransform.anchoredPosition = new Vector2(touchPosition.x * imageBackground.rectTransform.sizeDelta.x / 4, touchPosition.y * imageBackground.rectTransform.sizeDelta.y / 4);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        imageController.rectTransform.anchoredPosition = Vector2.zero;
        touchPosition = Vector2.zero;
    }

    public float Horizontal()
    {
        return touchPosition.x;
    }

    public float Vertical() 
    {
        return touchPosition.y;
    }
}
