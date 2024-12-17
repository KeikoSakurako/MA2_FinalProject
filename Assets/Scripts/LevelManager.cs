using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("------Player---------")]
    [SerializeField] public GameObject[] _lives;
    [SerializeField] int _playerLifes;

    [Header("------Generation------")]
    [SerializeField] public BrickGeneration _brickgen;
    public int _breakCounter = 0;
    public int _blockCount = 0;

    [Header("------Timer--------")]
    [SerializeField] Text _timerText;
    [SerializeField] float _remainTime;

    public GameObject _winPanel;
    public GameObject _gameoverPanel;

    public bool _isStart = false;
    bool _isgame = true;
    bool _iswin = true;


    public BossBattle _limbo;

    void Update()
    {
        if (_isStart == true)
        {
            if (_remainTime > 0)
            {
                _remainTime -= Time.deltaTime;
            }
            else if (_remainTime < 0)
            {
                _remainTime = 0;

                
                WinPanel();

            }
        }
        int mins = Mathf.FloorToInt(_remainTime / 60);
        int secs = Mathf.FloorToInt(_remainTime % 60);
        _timerText.text = string.Format("{0:00}:{1:00}", mins, secs);

        if(_breakCounter >= _blockCount)
        {
            _brickgen.SetNewGeneration();
            _breakCounter = 0;
        }

    }

    public void GameOverPanel()
    {
        if (_isgame == true)
        {
            Time.timeScale = 0f;
            _gameoverPanel.SetActive(true);

            _isgame = false;

        }
        else
        {
            Time.timeScale = 1f;
            _gameoverPanel.SetActive(false);
            _isgame = true;

        }
    }

    public void WinPanel()
    {
        if (_iswin == true)
        {
            Time.timeScale = 0f;
            _winPanel.SetActive(true);

            _iswin = false;

        }
        else
        {
            Time.timeScale = 1f;
            _winPanel.SetActive(false);
            _iswin = true;

        }
    }


    public void PlayerDMG(int dmg)
    {
        _playerLifes -= dmg;
        _lives[_playerLifes].SetActive(false);

        if (_playerLifes == 0)
        {
            GameOverPanel();
            Debug.Log("GameOver");
        }

    }

    public void StartTimer()
    {
        _isStart = true;
    }

    //===========================================


    public void Quit()
    {
        Debug.Log("AppQuit");
        Application.Quit();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGame");
    }
}
