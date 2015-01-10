using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InspectableObjectComponent : MonoBehaviour 
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

		PlayerSelectorController.Instance.SetSelectedObject(this.gameObject);
	}

    public void LostFocus()
    {
        if (Canvas) {
            Canvas.enabled = false;
        }
    }
}
