using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public float currenttime;
    public TextMeshProUGUI healthtext;
    public TextMeshProUGUI time;
    SpriteRenderer myspriteRenderer;
    public bool Imcolliding;
    private void Awake()
    {
        Imcolliding = false;
        myspriteRenderer = GetComponent<SpriteRenderer>();
        currenttime = 0;
    }
    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        currenttime = Time.deltaTime + currenttime;
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
            transform.position = new Vector2(-7, -3.385f);
        }
        Updatetext();
    }
    private void Updatetext()
    {
        healthtext.text = "Vida: " + currentHealth;
        time.text = "Tiempo: " + Mathf.FloorToInt(currenttime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Imcolliding = true;
        if (collision.gameObject.GetComponent<SpriteRenderer>().color != myspriteRenderer.color)
        {
            if (collision.gameObject.tag == "KindEarth" || collision.gameObject.tag == "KindAir" || collision.gameObject.tag == "KindStatic")
            {
                currentHealth--;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "KindEarth" || collision.gameObject.tag == "KindAir" || collision.gameObject.tag == "KindStatic")
        {
            Imcolliding = false;
        }
    }
}
