using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class spawnEnemy : MonoBehaviour
{
    public Transform[] spawnPoints;
    public int wave = 0;

    public GameObject[] Enemies;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GameObject.FindGameObjectWithTag("Peasant") && !GameObject.FindGameObjectWithTag("Knight") && !GameObject.FindGameObjectWithTag("PeasantTrident")) {
            wave++;
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            playerController playerCont = Player.GetComponent<playerController>();
            playerCont.transform.position = new Vector2(0,0);
            switch (wave) {
            

            case 1:
            int spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                break;
            case 2:
                 spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    break;
            case 3:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);

                    break;
            case 4:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    break;
            case 5:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    break;
            case 6:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[3], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    break;
            case 7:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[0], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[1], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);

                    break;

            case 8:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    break;
            case 9:
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[4], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[4], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    Instantiate(Enemies[2], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
                    spawnIndex = Random.Range(0, spawnPoints.Length);
                    break;
            case 10:
                    SceneManager.LoadScene("Win");
                    break;

            }
        }
    }


}
