using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Scythe"))
        {
            //hit shield sound
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            playerController playerCont = Player.GetComponent<playerController>();
            playerCont.confused = true;
        }
    }
}
