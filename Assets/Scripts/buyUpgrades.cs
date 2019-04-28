using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyUpgrades : MonoBehaviour
{
    public int weaponDamageIncrease;
    public float weaponSizeIncrease;
    public int playerHealthIncrease;
    public void MoreDamage()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        playerController playerCont = Player.GetComponent<playerController>();
        if (playerCont.souls >= 5)
        {

            GameObject Scythe = GameObject.FindGameObjectWithTag("Scythe");
            Scythe scythe = Scythe.GetComponent<Scythe>();

            scythe.damage += weaponDamageIncrease;
            playerCont.souls -= 5;
        }
        else
        {
            soundmanager.PlaySound("Error");
        }
    }
    public void WeaponSize()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        playerController playerCont = Player.GetComponent<playerController>();
        if (playerCont.souls >= 5)
        {
            GameObject Scythe = GameObject.FindGameObjectWithTag("Scythe");
            Scythe scythe = Scythe.GetComponent<Scythe>();

            scythe.transform.localScale += new Vector3(weaponSizeIncrease, weaponSizeIncrease, 0);
            playerCont.souls -= 5;
        }
        else
        {
            soundmanager.PlaySound("Error");
        }
    }
    public void Health()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        playerController playerCont = Player.GetComponent<playerController>();

        if (playerCont.souls >= 5)
        {
            playerCont.health += playerHealthIncrease;
            playerCont.souls -= 5;
        }
        else {
            soundmanager.PlaySound("Error");
        }
    }
}
