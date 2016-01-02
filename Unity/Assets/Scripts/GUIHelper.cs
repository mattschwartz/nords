using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GUIHelper : MonoBehaviour
{
    public static bool MouseOnGUI;

    void FixedUpdate()
    {
        MouseOnGUI = false;

        var pointer = new PointerEventData(EventSystem.current);
        pointer.position = Input.mousePosition;

        var raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer, raycastResults);

        if (raycastResults.Count > 0) {
            MouseOnGUI = true;
        }
    }
}
