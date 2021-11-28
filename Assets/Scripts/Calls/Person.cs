using System;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class Person : MonoBehaviour
{
   public bool isCall = false;

   public float xOffset = 2;
   public float yOffset = 20;
   public float zOffset = 2;
   
   
   public GameObject phonePref;
   public GameObject phone;
   
   private Vector3 par;
   

   private void Start()
   {
      par = new Vector3(this.gameObject.transform.position.x + xOffset ,this.gameObject.transform.position.y+yOffset,
         this.gameObject.transform.position.z + zOffset);
      if (Random.Range(1, 10) >= 3)
      {
         CreatePhone();
         isCall = true;
      }
   }

   private void OnMouseDown()
   {
      if (phone!=null)
      {
         Destroy(phone.gameObject);
         isCall = false;
      }
   }

   private void CreatePhone()
   {
      phone = Instantiate(phonePref,par,Quaternion.Euler(0,0,0),this.gameObject.transform);
   }
}
