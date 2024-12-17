using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] float _remainTime;
    
    public GameObject _restartPanel;
    
    public bool _isStart = false;
    bool _isgame = true;
   

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

                GameOverPanel();

            }
        }
        int mins = Mathf.FloorToInt(_remainTime / 60);
        int secs = Mathf.FloorToInt(_remainTime % 60);
        _timerText.text = string.Format("{0:00}:{1:00}", mins, secs);
    }

    public void GameOverPanel()
    {
        if (_isgame == true)
        {
            Time.timeScale = 0f;
            _restartPanel.SetActive(true);

            _isgame = false;

        }
        else
        {
            _restartPanel.SetActive(false);
            _isgame = true;

        }
    }

}
