using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class ButtonController : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer playerspriteRenderer;
    public Button mybutton;
    private void Awake()
    {
        mybutton = GetComponent<Button>();
        playerspriteRenderer = player.GetComponent<SpriteRenderer>();
        mybutton.onClick.AddListener(ChangePlayerColor);
    }
    public void ChangePlayerColor()
    {
        Color buttonColor = GetComponent<Image>().color;
        playerspriteRenderer.color = buttonColor;
    }
}
