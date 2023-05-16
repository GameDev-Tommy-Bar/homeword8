using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunchange : MonoBehaviour
{
   public GameObject Slot1;
    public GameObject Slot2;    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetKeyDown("1"))
        {
            Equip1();
        }

        if(Input.GetKeyDown("2"))
        {
            Equip2();
        }

     
    }

    void Equip1()
    {
        Slot1.SetActive(true);
        Slot2.SetActive(false);
  
    }

    void Equip2()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(true);
       
    }
    
}
