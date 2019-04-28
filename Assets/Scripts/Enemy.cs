using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform bloodEffect;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            playerController playerCont = Player.GetComponent<playerController>();
            playerCont.souls += 1;
            Destroy(gameObject);

        }
    }
    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= damage;
    }
}
