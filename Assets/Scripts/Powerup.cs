using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Powerup : MonoBehaviour
{
    public Canvas UpgradeUI;
    public GameObject Control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D col)
    {
         if (col.gameObject.tag == "Player")
         {
            Control.SetActive(true);
           if (Input.GetKeyDown(KeyCode.RightControl)) {
                UpgradeUI.gameObject.SetActive(true);
                soundmanager.PlaySound("Ding");
            }
       }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Control.SetActive(false);
            UpgradeUI.gameObject.SetActive(false);
        }
    }
}
