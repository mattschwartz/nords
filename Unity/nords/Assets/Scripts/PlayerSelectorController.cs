using UnityEngine;
using System.Collections;

public class PlayerSelectorController : MonoBehaviour 
{
    private GameObject SelectedObject;

    public SelectorHighlighterController Selector;
    public static PlayerSelectorController Instance { get; private set; }

    void Start()
    {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(this);
        } else if (this != Instance) {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if (GUIHelper.MouseOnGUI || !Input.GetMouseButtonDown(0)) { return; }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (!Physics.Raycast(ray, out hit, 100.0F) ||
            !hit.collider.gameObject.GetComponent<InspectableObjectComponent>()) {
            Selector.SetSelectedObject(null);
            ClearFocus();
        } 
    }

    public void SetSelectedObject(GameObject other)
    {
        if (other == SelectedObject) { return; }

        ClearFocus();
        SelectedObject = other;
        Selector.SetSelectedObject(other);
    }

    public void ClearFocus()
    {
        Selector.SetSelectedObject(null);
        if (!SelectedObject) { return; }

        var inspectable = SelectedObject.GetComponent<InspectableObjectComponent>();

        if (inspectable != null) {
            inspectable.LostFocus();
        }
        
        SelectedObject = null;
    }
}
