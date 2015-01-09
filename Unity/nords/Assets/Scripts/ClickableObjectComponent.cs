using UnityEngine;
using System.Collections;

public class ClickableObjectComponent : MonoBehaviour 
{
	public SelectorController Selector;

	void OnMouseEnter()
	{
		Selector.SetSelectedObject(gameObject);
	}

	void OnMouseExit()
	{
		Selector.SetSelectedObject(null);
	}
}
