﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TargetManager : MonoBehaviour {

    public GameObject target;
    public GameObject[] locations;

    int random;

	void Start () 
    {
        SpawnTarget(1);
    //    RemoveInstances();
	}	
	void Update () {
	
	}
   public void SpawnTarget(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            random = Random.Range(0, 3);
            GameObject _target = Instantiate(target, locations[random].transform.position, Quaternion.identity) as GameObject;
        }   
    }
  /*  void RemoveInstances()
    {
        TargetHit[] tempTargetsArray = new TargetHit[4];

        tempTargetsArray = FindObjectsOfType(typeof(TargetHit)) as TargetHit[];
        for (int i = 1; i < tempTargetsArray.Length; i++)
        {

        }*/
    }

