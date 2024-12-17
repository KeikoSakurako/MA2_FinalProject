using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimboParry : MonoBehaviour
{


    public GameObject _winpanel;
    public GameObject _gameover;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Limball"))
        {

            Debug.Log("Win Con");
            Time.timeScale = 0f;
            _winpanel.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Wrongball"))
        {
            Debug.Log("Lose Con");
            _gameover.SetActive(true);
        }
    }

    public void GameOverPanelClose()
    {
        
        
        Time.timeScale = 1f;
        _gameover.SetActive(false);
            
    }
}
