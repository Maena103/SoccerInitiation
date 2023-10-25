using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallonBut : MonoBehaviour
{

    [SerializeField] ParticleSystem Particule;
    [SerializeField] GameObject PositionDepart;

   private void OnTriggerEnter(Collider other)
   {
      if(other.transform.tag == "Victoire"){
          Particule.Play();
          this.transform.position = PositionDepart.transform.position;
    }
   }
}
