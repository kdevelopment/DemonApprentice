using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerController : MonoBehaviour
{
    public float speed;
    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    public int health;
    public int souls;
    public Transform bloodEffect;

    public Text Health;
    public Text Damage;
    public Text TextSouls;
    public Text uiTextSouls;
    public Text currentWave;
    private bool canmove = true;
    public bool confused = false;
    private float confusedTime = 0;
    public int actualConfusedTime;
    private float footstepTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Scythe = GameObject.FindGameObjectWithTag("Scythe");
        Scythe scythe = Scythe.GetComponent<Scythe>();
        GameObject spawn = GameObject.Find("SpawnEnemy");
        spawnEnemy spawnEnemies = spawn.GetComponent<spawnEnemy>();
        Health.text = "" + health;
        Damage.text = "" + scythe.damage;
        TextSouls.text = "" + souls;
        uiTextSouls.text = "" + souls;
        currentWave.text = "" + spawnEnemies.wave;

        footstepTime += Time.deltaTime;
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * speed;
        faceMouse();
        if (health <= 0)
        {
            SceneManager.LoadScene("Restart");
        }
    }
    private void FixedUpdate()
    {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            
    }
    void faceMouse()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        if (!confused)
        {
            transform.up = direction;
        }
        else if (confused) {
            transform.up = direction * -1;
            confusedTime += Time.deltaTime;
            
        }
        if (confusedTime > actualConfusedTime) {
            confused = false;
            confusedTime = 0;
        }
    }
    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= damage;

    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("wall"))
        {
            transform.position = new Vector2(0, 0);
        }
    }
    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == ("wall"))
        {
            transform.position = new Vector2(0, 0);
        }
    }
}


   


