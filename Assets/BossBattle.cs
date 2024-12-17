using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattle : MonoBehaviour
{
    public GameObject _UIPanels;
    public GameObject _ball;
    public GameObject _bricks;

    public GameObject _gameOver;

    public AudioManager _audis;
    public GameObject _limbo;
    public Animator anims;

    public int spincountleft = 0;
    public int spincountright = 0;
    void Update()
    {
        if(spincountleft >= 3)
        {
            anims.SetBool("presec", true);
        }

        if (spincountright >= 2)
        {
            anims.SetBool("prekey", true);
        }
    }


    public void LimboStart()
    {
        Time.timeScale = 1f;
        _limbo.SetActive(true);
        _audis.Limbo();

        _bricks.SetActive(false);
        _ball.SetActive(false);
        _UIPanels.SetActive(false);
    }

    public void CountLeft()
    {
        spincountleft++;
    }
    public void CountRigt()
    {
        spincountright++;
    }

    public void NoTime()
    {
        _gameOver.SetActive(true);
    }
}
