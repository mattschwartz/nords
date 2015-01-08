using UnityEngine;
using System.Collections;

public class ResourcePointGUIController : MonoBehaviour 
{
    private ResourcePointController _resource;

    public void SetResource(ResourcePointController resource) 
    {
        if (_resource != null) {
            _resource.SetFocus(false);
        }

        if (resource == null) { return; }

        _resource = resource;
        _resource.SetFocus(true);
    }
}
