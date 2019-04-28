using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliteSoldier : MonoBehaviour
{
    public int damage;
    public float speed;
    private Transform target;
    public bool move = true;
    private float attackSpeed = 1;
    public int fast = 1;
    private Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime * fast);
          
        }
        //transform.LookAt(target);
    }
    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == ("enemyAttackArea"))
        {
            move = true;

        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "farEnemyAttackArea")
        {
            fast = 4;
            move = false;
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            playerController playerCont = Player.GetComponent<playerController>();
            playerPos = playerCont.transform.position;
            
        }
    }
    public void OnCollisionStay2D(Collision2D col)

    {

        if (col.gameObject.tag == ("stopenemyAttackArea"))
        {
            move = false;
        }
        if (col.gameObject.tag == ("enemyAttackArea"))
        {
            fast = 1;
            attackSpeed += Time.deltaTime;
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            playerController playerCont = Player.GetComponent<playerController>();

            if (attackSpeed > 1.5)
            {
                playerCont.TakeDamage(damage);
                attackSpeed = 0;
            }
        }

    }
}
