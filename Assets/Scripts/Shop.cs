using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
	public int ballSelect;
	public int Gems;
	public Text GemT;
	public Text[] t;
	public int buy1;
	public int buy2;
	public int buy3;
	public int buy4;
	public int buy5;
	public int buy6;
	public int buy7;
	public int buy8;
	public int buy9;
	public int buy10;
	public int buy11;
	public int buy12;
	public int buy13;
	public int buy14;
	public int buy15;
	public int buy16;
	public int cost1;
	public int cost2 = 10;
	public int cost3 = 15;
	public int cost4 = 20;
	public int cost5 = 25;
	public int cost6 = 30;
	public int cost7 = 35;
	public int cost8 = 40;
	public int cost9 = 75;
	public int cost10 = 75;
	public int cost11 = 100;
	public int cost12 = 100;
	public int cost13 = 250;
	public int cost14 = 250;
	public int cost15 = 500;
	
	void Start()
	{	
		cost2 = 10;
		cost3 = 15;
		cost4 = 20;
		cost5 = 25;
		cost6 = 30;
		cost7 = 35;
		cost8 = 40;
		cost9 = 75;
		cost10 = 75;
		cost11 = 100;
		cost12 = 100;
		cost13 = 250;
		cost14 = 250;
		cost15 = 500;
		buy1 = 1;
		buy2 = PlayerPrefs.GetInt("buy2");
		buy3 = PlayerPrefs.GetInt("buy3");
		buy4 = PlayerPrefs.GetInt("buy4");
		buy5 = PlayerPrefs.GetInt("buy5");
		buy6 = PlayerPrefs.GetInt("buy6");
		buy7 = PlayerPrefs.GetInt("buy7");
		buy8 = PlayerPrefs.GetInt("buy8");
		buy9 = PlayerPrefs.GetInt("buy9");
		buy10 = PlayerPrefs.GetInt("buy10");
		buy11 = PlayerPrefs.GetInt("buy11");
		buy12 = PlayerPrefs.GetInt("buy12");
		buy13 = PlayerPrefs.GetInt("buy13");
		buy14 = PlayerPrefs.GetInt("buy14");
		buy15 = PlayerPrefs.GetInt("buy15");
		buy16 = PlayerPrefs.GetInt("buy16");
		Gems = PlayerPrefs.GetInt("Gems");
		ballSelect = PlayerPrefs.GetInt("ballSelect");
		if(ballSelect == 0)
		{
			ballSelect = 1;
		}
		if(buy2 == 1)
		{
			t[0].text = " + ";
		}
		if(buy3 == 1)
		{
			t[1].text = " + ";
		}
		if(buy4 == 1)
		{
			t[3].text = " + ";
		}
		if(buy5 == 1)
		{
			t[3].text = " + ";
		}
		if(buy6 == 1)
		{
			t[4].text = " + ";
		}
		if(buy7 == 1)
		{
			t[5].text = " + ";
		}
		if(buy8 == 1)
		{
			t[6].text = " + ";
		}
		if(buy9 == 1)
		{
			t[7].text = " + ";
		}
		if(buy10 == 1)
		{
			t[8].text = " + ";
		}
		if(buy11 == 1)
		{
			t[9].text = " + ";
		}
		if(buy12 == 1)
		{
			t[10].text = " + ";
		}
		if(buy13 == 1)
		{
			t[11].text = " + ";
		}
		if(buy14 == 1)
		{
			t[12].text = " + ";
		}
		if(buy15 == 1)
		{
			t[13].text = " + ";
		}
	}
	
	void Update()
	{
		GemT.text = Gems.ToString();
	}
	
	public void Butt(int buttpressed)
    {
        switch(buttpressed)
		{
			case 1:
				if(buy1 == 0)
				{
				
				}
				else
				{
					ballSelect = 1;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 2:
				if(buy2 == 0)
				{
					if(Gems >= cost2)
					{
						Gems = Gems - cost2;
						PlayerPrefs.SetInt("Gems", Gems);
						buy2 = 1;
						PlayerPrefs.SetInt("buy2", buy2);
						ballSelect = 2;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[0].text = " + ";
					}
				}
				else
				{
					ballSelect = 2;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 3:
				if(buy3 == 0)
				{
					if(Gems >= cost3)
					{
						Gems = Gems - cost3;
						PlayerPrefs.SetInt("Gems", Gems);
						buy3 = 1;
						PlayerPrefs.SetInt("buy3", buy3);
						ballSelect = 3;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[1].text = " + ";
					}
				}
				else
				{
					ballSelect = 3;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 4:
				if(buy4 == 0)
				{
					if(Gems >= cost4)
					{
						Gems = Gems - cost4;
						PlayerPrefs.SetInt("Gems", Gems);
						buy4 = 1;
						PlayerPrefs.SetInt("buy4", buy4);
						ballSelect = 4;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[2].text = " + ";
					}
				}
				else
				{
					ballSelect = 4;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 5:
				if(buy5 == 0)
				{
					if(Gems >= cost5)
					{
						Gems = Gems - cost5;
						PlayerPrefs.SetInt("Gems", Gems);
						buy5 = 1;
						PlayerPrefs.SetInt("buy5", buy5);
						ballSelect = 5;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[3].text = " + ";
					}
				}
				else
				{
					ballSelect = 5;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 6:
				if(buy6 == 0)
				{
					if(Gems >= cost6)
					{
						Gems = Gems - cost6;
						PlayerPrefs.SetInt("Gems", Gems);
						buy6 = 1;
						PlayerPrefs.SetInt("buy6", buy6);
						ballSelect = 6;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[4].text = " + ";
					}
				}
				else
				{
					ballSelect = 6;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 7:
				if(buy7 == 0)
				{
					if(Gems >= cost7)
					{
						Gems = Gems - cost7;
						PlayerPrefs.SetInt("Gems", Gems);
						buy7 = 1;
						PlayerPrefs.SetInt("buy7", buy7);
						ballSelect = 7;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[5].text = " + ";
					}
				}
				else
				{
					ballSelect = 7;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 8:
				if(buy8 == 0)
				{
					if(Gems >= cost8)
					{
						Gems = Gems - cost8;
						PlayerPrefs.SetInt("Gems", Gems);
						buy8 = 1;
						PlayerPrefs.SetInt("buy8", buy8);
						ballSelect = 8;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[6].text = " + ";
					}
				}
				else
				{
					ballSelect = 8;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 9:
				if(buy9 == 0)
				{
					if(Gems >= cost9)
					{
						Gems = Gems - cost9;
						PlayerPrefs.SetInt("Gems", Gems);
						buy9 = 1;
						PlayerPrefs.SetInt("buy9", buy9);
						ballSelect = 2;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[7].text = " + ";
					}
				}
				else
				{
					ballSelect = 9;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 10:
				if(buy10 == 0)
				{
					if(Gems >= cost10)
					{
						Gems = Gems - cost10;
						PlayerPrefs.SetInt("Gems", Gems);
						buy10 = 1;
						PlayerPrefs.SetInt("buy10", buy10);
						ballSelect = 10;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[8].text = " + ";
					}
				}
				else
				{
					ballSelect = 10;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 11:
				if(buy11 == 0)
				{
					if(Gems >= cost11)
					{
						Gems = Gems - cost11;
						PlayerPrefs.SetInt("Gems", Gems);
						buy11 = 1;
						PlayerPrefs.SetInt("buy11", buy11);
						ballSelect = 11;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[9].text = " + ";
					}
				}
				else
				{
					ballSelect = 11;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 12:
				if(buy12 == 0)
				{
					if(Gems >= cost12)
					{
						Gems = Gems - cost12;
						PlayerPrefs.SetInt("Gems", Gems);
						buy12 = 1;
						PlayerPrefs.SetInt("buy12", buy12);
						ballSelect = 12;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[10].text = " + ";
					}
				}
				else
				{
					ballSelect = 12;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 13:
				if(buy13 == 0)
				{
					if(Gems >= cost13)
					{
						Gems = Gems - cost13;
						PlayerPrefs.SetInt("Gems", Gems);
						buy13 = 1;
						PlayerPrefs.SetInt("buy13", buy13);
						ballSelect = 13;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[11].text = " + ";
					}
				}
				else
				{
					ballSelect = 13;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 14:
				if(buy14 == 0)
				{
					if(Gems >= cost14)
					{
						Gems = Gems - cost14;
						PlayerPrefs.SetInt("Gems", Gems);
						buy14 = 1;
						PlayerPrefs.SetInt("buy14", buy14);
						ballSelect = 14;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[12].text = " + ";
					}
				}
				else
				{
					ballSelect = 14;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 15:
				if(buy15 == 0)
				{
					if(Gems >= cost15)
					{
						Gems = Gems - cost15;
						PlayerPrefs.SetInt("Gems", Gems);
						buy15 = 1;
						PlayerPrefs.SetInt("buy15", buy15);
						ballSelect = 15;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
						t[13].text = " + ";
					}
				}
				else
				{
					ballSelect = 15;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
				break;
			case 16:
				if(buy2 == 0)
				{
					if(Gems >= cost2)
					{
						Gems = Gems - cost2;
						PlayerPrefs.SetInt("Gems", Gems);
						buy2 = 1;
						PlayerPrefs.SetInt("buy2", buy2);
						ballSelect = 2;
						PlayerPrefs.SetInt("ballSelect", ballSelect);
					}
				}
				else
				{
					ballSelect = 2;
					PlayerPrefs.SetInt("ballSelect", ballSelect);
				}
			break;
		}
    }
	
}