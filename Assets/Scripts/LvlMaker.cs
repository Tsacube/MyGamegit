using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlMaker : MonoBehaviour
{
	public GameObject All;
	public GameObject[] E;
	public GameObject[] N;
	public GameObject[] H;
	public int lvlClose;
	public int c;
	public int a;
	public int b;
	
	
    void Start()
    {
		PlayerPrefs.SetInt("lvlClose", lvlClose);
		LvlRandom();
        LvlChouse();
		a =-1;
		b =-1;
    }

	public void LvlRandom()
	{
		c = Random.Range(0, E.Length);
		if(c == a | c == b)
		{
			LvlRandom();
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			E[c].SetActive(false);
			N[c].SetActive(false);
			H[c].SetActive(false);
			All.transform.position = new Vector3(0, 0, All.transform.position.z);
			b = a;
			a = c;
			LvlRandom();
			lvlClose++;
			PlayerPrefs.SetInt("lvlClose", lvlClose);
			LvlChouse();
		}
	}
	
	public void LvlChouse()
	{
		if(lvlClose < 3)
		{
			E[c].SetActive(true);
			transform.position = new Vector3(transform.position.x, 0, transform.position.z);
		}
		else if(lvlClose < 6)
		{
			N[c].SetActive(true);
			transform.position = new Vector3(transform.position.x, 0, transform.position.z);
		}
		else
		{
			H[c].SetActive(true);
			transform.position = new Vector3(transform.position.x, 0, transform.position.z);
		}
	}
}
