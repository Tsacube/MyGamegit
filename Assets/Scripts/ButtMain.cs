using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtMain : MonoBehaviour
{
	public GameObject Info;
	public GameObject Options;
	
	public void Infoo()
	{
		Info.SetActive(true);
	}
	
	public void InfooClose()
	{
		Info.SetActive(false);
	}
	
	public void Optioons()
	{
		Options.SetActive(true);
	}
	
	public void OptioonsClose()
	{
		Options.SetActive(false);
	}
}
