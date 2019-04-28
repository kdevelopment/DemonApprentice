using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scythe : MonoBehaviour
{

    public int damage;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("Peasant"))
        {
            GameObject enem = col.gameObject;
            Enemy enemy = enem.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
            soundmanager.PlaySound("Oof");
        }
        if (col.gameObject.tag == ("PeasantTrident"))
        {
            GameObject enem = col.gameObject;
            Enemy enemy = enem.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
            soundmanager.PlaySound("Oof");
        }
        if (col.gameObject.tag == ("Knight"))
        {
            GameObject enem = col.gameObject;
            Enemy enemy = enem.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
            soundmanager.PlaySound("Oof");
        }
        if (col.gameObject.tag == ("ShieldKnight"))
        {
            GameObject enem = col.gameObject;
            Enemy enemy = enem.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
            soundmanager.PlaySound("Oof");
        }
        
    }
}
