﻿using UnityEngine;
using System.Collections;

public class Factions : MonoBehaviour {

	private string name;
	private Color FacColor;
	private GameObject boids;


	ArrayList targets = new ArrayList();
	ArrayList members = new ArrayList();


	public Factions(string name,Color FacColor, Vector3 headQuartersloc,GameObject boids){

		this.name = name;
		this.FacColor = FacColor;
		this.boids = boids;

		for(int i = 0; i < 10; i++)
		members.Add(Instantiate(boids,headQuartersloc,Quaternion.identity)as GameObject);



	}

	public void Update (){

		Debug.Log("Fractions-Member-Update");
		foreach(GameObject cel in members){
			
			CellNav cell = cel.GetComponent<CellNav>() as CellNav ;
			if(cell.goal == null){

				cell.setTarget(targets[0] as GameObject);
				targets.RemoveAt(0);
			}
			
		}
	}

	public void setTarget(ArrayList objects){

		targets = objects;
	}


}
