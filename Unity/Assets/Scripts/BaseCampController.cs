using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BaseCampController : MonoBehaviour 
{
    public Text GoldResourceText;
    public Text LumberResourceText;
    private int goldCollected;
    private int lumberCollected;

	void Start() 
    {
        goldCollected = 0;
        lumberCollected = 0;
        GoldResourceText.text = "Gold Collected: 0";
        LumberResourceText.text = "Lumber Collected: 0";
	}
	
	void FixedUpdate()
    {
        GoldResourceText.text = "Gold Collected: " + goldCollected.ToString("n0");
        LumberResourceText.text = "Lumber Collected: " + lumberCollected.ToString("n0");
	}
}
