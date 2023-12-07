using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    Health damage;

    public GameObject hitPoints;
    

    // Start is called before the first frame update
    void Start()
    {
        damage = hitPoints.GetComponent<Health>();
    }


    public bool left;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
        }

        if (coll.tag =="Wall" && left == true)
        {
            left = false;
        }

        else if (coll.tag == "Wall" && left == false) 
        {
            left = true;
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("Hit");
        }

    }
}
