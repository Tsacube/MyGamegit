using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBase : MonoBehaviour
{
	public Rigidbody2D rbBox;
	public int lvlClose;
	
    void Start()
    {
		lvlClose = PlayerPrefs.GetInt("lvlClose");
		if(lvlClose < 3)
		{
			rbBox = GetComponent<Rigidbody2D>();
			rbBox.AddForce(Vector2.up * 8000);
		}
		else if(lvlClose < 6)
		{
			rbBox = GetComponent<Rigidbody2D>();
			rbBox.AddForce(Vector2.up * 10000);
		}
		else
		{
			rbBox = GetComponent<Rigidbody2D>();
			rbBox.AddForce(Vector2.up * 12000);
		}
    }
}