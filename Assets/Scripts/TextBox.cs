using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public GameObject textBox;
    public Text text;
    public string Info;

    public bool oneTime = false;

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textBox.gameObject.SetActive(true);
        text.text = Info.ToString();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        textBox.gameObject.SetActive(false);
        text.text = ' '.ToString();

        if (oneTime)
        {
            GameObject.Destroy(gameObject);
        }
    }


}
