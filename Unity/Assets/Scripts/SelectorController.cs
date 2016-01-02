using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour 
{
    public int RotateSpeed = 2;
    private GameObject SelectedObject;

    public static SelectorController Instance { get; private set; }

	void Start()
    {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(this);
        } else if (this != Instance) {
            Destroy(gameObject);
        }

        gameObject.SetActive(false);
	}
	
	void FixedUpdate()
    {
        gameObject.transform.Rotate(Vector3.up, RotateSpeed);
    }

    /// <summary>
    /// Clears focus if user clicks off a selectable game object
    /// </summary>
    void Update()
    {
        if (GUIHelper.MouseOnGUI || !Input.GetMouseButtonDown(0)) { return; }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (!Physics.Raycast(ray, out hit, 100.0F) ||
            !hit.collider.gameObject.GetComponent<SelectableGameObject>()) {
            SetSelectedObject(null);
            ClearFocus();
        }
    }

    public void SetSelectedObject(GameObject other)
    {
        if (other == SelectedObject) { return; }

        ClearFocus();
        SelectedObject = other;
        SetSelectorPosition(other);
    }

    public void ClearFocus()
    {
        SetSelectorPosition(null);
        if (!SelectedObject) { return; }

        var selectable = SelectedObject.GetComponent<SelectableGameObject>();

        if (selectable != null) {
            selectable.LostFocus();
        }

        SelectedObject = null;
    }

    private void SetSelectorPosition(GameObject other)
    {
        if (other == null) {
            gameObject.SetActive(false);
            return;
        }

        transform.parent = other.transform;
        gameObject.SetActive(true);
        Vector3 newPos = other.transform.position;

        int tries = 0;

        do
        {
            ++tries;
            newPos.y += 0.25f;

            if (tries > 25) {
                break;
            }
        } while (Physics.OverlapSphere(newPos, 1).Length > 0);

        transform.position = newPos;
    }
}
