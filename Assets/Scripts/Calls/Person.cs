using System;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class Person : MonoBehaviour
{
   public bool isCall = false;
   
   public GameObject phonePref;
   public GameObject phone;
   private Vector3 par;
   

   private void Start()
   {
      par = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y+5,this.gameObject.transform.position.z);
      if (Random.Range(1, 10) > 3)
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
      phone = Instantiate(phonePref,par,Quaternion.identity,this.gameObject.transform);
   }
}
