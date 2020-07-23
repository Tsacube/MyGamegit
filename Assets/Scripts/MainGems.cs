using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGems : MonoBehaviour
{
	public int Gems;
	public Text GemT;
	
    void Start()
    {
        Gems = PlayerPrefs.GetInt("Gems");
		GemT.text = Gems.ToString();
		
    }

}
