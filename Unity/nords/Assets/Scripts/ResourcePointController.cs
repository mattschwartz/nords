using UnityEngine;
using System.Collections;

public abstract class ResourcePointController : MonoBehaviour 
{
    private bool _hasFocus;
    private int _availableResources;
    private string _name;

    public bool BeginActive;

    public int AvailableResources {
        get 
        {
            return _availableResources;
        }

        protected set 
        {
            _availableResources = value;
        }
    }

    public string Name {
        get
        {
            return _name;
        }

        protected set
        {
            _name = value;
        }
    }

    // [ NYI ]
    public GameObject Worker;

    void Start()
    {
        _hasFocus = BeginActive;
    }

    public void SetFocus(bool focus)
    {
        _hasFocus = focus;

        if (_hasFocus) {
            FocusGained();
        } else {
            FocusLost();
        }
    }

    protected abstract void FocusLost();

    protected abstract void FocusGained();
}
