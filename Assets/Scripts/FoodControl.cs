using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FoodControl : MonoBehaviour
{
    //public Transform normalApple, normalChili, normalSando, normalBrocco, normalChip, normalChoco, normalResist, normalSoup, normalSushi;
    //public Transform cyborgChip, cyborgResist, cyborgBrocco, cyborgSushi, cyborgSando, cyborgSoup, cyborgChoco, cyborgChili, cyborgApple;

    [SerializeField]
    private Canvas canvas;

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
            pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);
    }
}
