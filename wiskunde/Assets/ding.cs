using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ding : MonoBehaviour
{
	public float Damage;
	public float mainDamage;
	public float pBonus;
	public float fBonus;
	public float critMutiplier;
	public float blokDamage;
	public float aMutiplier;
	public float generalDamageMultiplier;

	public Text t;

	// Update is called once per frame
	public void Update ()
	{
		t.Text = Damage.ToString;
		Formule();
		print(Damage);
	}

	public float Formule()
	{
		Damage = ((mainDamage * (1 + pBonus) + fBonus) * critMutiplier - blokDamage) * aMutiplier * generalDamageMultiplier;
		return Damage;
	}
}
