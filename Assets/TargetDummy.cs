using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
   private void OnCollisionEnter(Collision other){
    if(other.gameObject.CompareTag("Bullet")){
        Debug.Log("I've been hit");
    }
   }
}
