using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotBullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemybullet;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject Player;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
        //InvokeRepeating("shot", 0,2f);
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    void shot()
    {
        Debug.Log("Player is within range!");

        var enemyBulletIns = Instantiate(enemybullet, firePoint.position, firePoint.rotation);
        Destroy(enemyBulletIns, 2f);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //shot();
            //Invoke("shot", 2f);
            timer += Time.deltaTime;
            if (timer > 2)
            {
                shot();
                timer = 0;
            }
        }
    }
   
}
