using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
  public static bool IsPlayerNearFire = false;

  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  private void OnTriggerExit(Collider other)
  {
    IsPlayerNearFire = false;
  }

  private void OnTriggerStay(Collider other)
  {
    IsPlayerNearFire = true;
  }
}
