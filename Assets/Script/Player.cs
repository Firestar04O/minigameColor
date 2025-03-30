using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public TextMeshProUGUI healthtext;
    SpriteRenderer myspriteRenderer;
    private void Awake()
    {
        myspriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        if(currentHealth <= 0)
        {
            currentHealth = maxHealth;
            transform.position = new Vector2(-7, -3.385f);
        }
        Updatetext();
    }
    private void Updatetext()
    {
        healthtext.text = "Vida: " + currentHealth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<SpriteRenderer>().color != myspriteRenderer.color)
        {
            if (collision.gameObject.tag == "KindEarth" || collision.gameObject.tag == "KindAir" || collision.gameObject.tag == "KindStatic")
            {
                currentHealth--;
            }
        }
    }
}
