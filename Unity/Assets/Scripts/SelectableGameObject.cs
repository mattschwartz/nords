using UnityEngine;
using System.Collections;

public class SelectableGameObject : MonoBehaviour 
{
    public Canvas Canvas;

    void Start()
    {
        if (Canvas) {
            Canvas.enabled = false;
        }
    }

    void OnMouseDown()
    {
        if (Canvas) {
            Canvas.enabled = true;
        }

        SelectorController.Instance.SetSelectedObject(this.gameObject);
    }

    public void LostFocus()
    {
        if (Canvas) {
            Canvas.enabled = false;
        }
    }
}
