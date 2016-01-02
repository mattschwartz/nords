using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldMineController : MonoBehaviour 
{
    private int goldRemaining;

	void Start() 
    {
        goldRemaining = Random.Range(0, 99999);
	}
	
	void FixedUpdate() 
    {
	}
}
