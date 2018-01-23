using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
	public Slider food;
	public Slider wc;
	public Slider energie;
	public Move move;

	public void Update()
	{
		LowerBar();
		Movingto();
	}

	public void LowerBar()
	{//food.value > 0 || move.WTD != Move.WatTeDoen.ET
		if (GameObject.Transform.posision = move.foodpos)
		{
			food.value -= 0.1f * Time.deltaTime ;
		}
	}

	public void Movingto()
	{
		if (food.value < 1.0f)
		{
			move.WTD = Move.WatTeDoen.ET;
			move.Moving();
		}
		if (move.WTD == Move.WatTeDoen.ET)
			{
				food.value += 0.2f * Time.deltaTime;
			}
	}

}
