using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFar : MonoBehaviour
{
    public int damage;
    public float speed;
    private Transform target;
    public bool move = true;
    private float attackSpeed = 1;
    public float actualAttackSpeed;
    public float fast = 1;
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
            fast = 3;
        }
    }
    public void OnCollisionStay2D(Collision2D col)
           
    {
        
        if (col.gameObject.tag == ("stopenemyAttackArea"))
        {
            Debug.Log("done2");
            move = false;
        }
        if (col.gameObject.tag == ("enemyAttackArea"))
        {
            fast = 1;
            attackSpeed += Time.deltaTime;
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            playerController playerCont = Player.GetComponent<playerController>();

            if (attackSpeed > actualAttackSpeed)
            {
                soundmanager.PlaySound("Oof");
                playerCont.TakeDamage(damage);
                attackSpeed = 0;
            }
        }

    }


}
