using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private SpriteRenderer sp;
    private float x;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
       
        state_water();

    }
  void state_water()
    {

        timer += Time.deltaTime;

      if (timer > 0.35)
        {

            sp.flipX = true;
            
            timer = 0;


        }
        else 
        {
            sp.flipX = false;
           
           

        }

        
    }
}
