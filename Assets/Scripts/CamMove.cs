using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
	public Animator CamA;
	public int diee;
	
    void Start()
    {
        CamA = GetComponent<Animator>();
		CamA.SetBool("die", false); 
    }


    void Update()
    {
		diee = PlayerPrefs.GetInt("diee");
        if (diee == 1)
		{
			CamA.SetBool("die", true);
		}
    }
}
