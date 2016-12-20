using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour {
  AudioSource audio;
  AudioClip clip;

  public static bool IsPlayerOnSniperPlane = false;

  void Start() {
    audio = gameObject.AddComponent<AudioSource>();
    audio.volume = 1;
    clip = Resources.Load<AudioClip>("gun18");
    
   InvokeRepeating("RepeatingFunction", 0, 3);
  }

  void Update() {
  
  }

  void RepeatingFunction()
  {
    if (IsPlayerOnSniperPlane)
    {
      if (Random.Range(0, 5) == 0)
      {
        audio.PlayOneShot(clip, 1.0F);

        if (Random.Range(0, 4) == 0)
        {
          IsPlayerOnSniperPlane = false;

          Application.LoadLevel(0);
        }
      }
    }
  }

  private void OnTriggerExit(Collider other)
  {
    IsPlayerOnSniperPlane = false;
  }

  private void OnTriggerStay(Collider other)
  {
    IsPlayerOnSniperPlane = true;
  }
}
