using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
	public string Name;
	public int Calories;
	public int Karmas;
	public bool Alive;
	public string Message;

	private void OnMouseDown()
	{
		UseItem();
	}

	public virtual void UseItem()

	{
		


		Debug.Log("Clicked");

	}
}
