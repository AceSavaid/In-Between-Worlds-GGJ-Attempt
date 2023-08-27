using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject game;
    public GameObject end;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        game.gameObject.SetActive(false);
        end.gameObject.SetActive(true);
    }
}
