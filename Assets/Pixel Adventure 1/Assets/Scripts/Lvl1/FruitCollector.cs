using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitCollector : MonoBehaviour
{
	[SerializeField] private Text fruitText; //The text left top of your screen

	private int fruitScore; //How much fruit you've collected

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Strawberry")) //If you touch a strawberry
		{
			Destroy(collision.gameObject); //Destroys the strawberry
			fruitScore++;
			fruitText.text = "Tutti Fruiti: " + fruitScore; //This is put in the left top of your screen, the fruitscore gets turned into a changing string
		}
	}
}
