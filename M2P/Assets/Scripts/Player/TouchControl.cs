using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControl : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData) // Drag for jump. Unusable. Improvements needed.
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if (eventData.delta.x > 0)
            {
                Debug.Log("up");
            }
            else
            {
                Debug.Log("down");
            }
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                Debug.Log("left");
            }
            else
            {
                Debug.Log("uright");
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
