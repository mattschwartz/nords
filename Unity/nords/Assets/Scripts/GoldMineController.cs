using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldMineController : MonoBehaviour 
{
    private bool Focused = false;
    private bool Over = false;

    public SpriteRenderer Renderer;
    public Text Txt;

    void FixedUpdate() 
    {
        if (Focused || Over) {
            Renderer.color = Color.white;
            Txt.text = "Gold Mine";
        } else {
            Renderer.color = new Color(0.75f, 0.75f, 0.75f, 1);
            Txt.text = "Nothing";
        }
    }

    void OnMouseDown()
    {
        Focused = !Focused;
    }

	void OnMouseEnter()
    {
        Over = true;
    }

    void OnMouseExit()
    {
        Over = false;
    }
}
