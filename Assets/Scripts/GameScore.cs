using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
	public int Gems;
	public int GemsNow;
	public int a;
	void Apapap()
	{
		Gems = PlayerPrefs.GetInt("Gems");
		GemsNow = PlayerPrefs.GetInt("GemsNow");
		a = Gems + GemsNow;
		PlayerPrefs.SetInt("Gems", a);
	}
}
