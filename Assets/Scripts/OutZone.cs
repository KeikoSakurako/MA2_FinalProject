using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutZone : MonoBehaviour
{
    [SerializeField] public LevelManager _lvlmanagaer;
    [SerializeField] public PhaseBall phs;
    [SerializeField] public AudioManager _auds;
    public bool _iszone = false;
    public bool _isparry = false;

    public int _zonedmg = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (_iszone == true)
            {
                Debug.Log("Damage");
                phs.ResetBall();
                _auds.PlayLifeSFX();
                _lvlmanagaer.PlayerDMG(_zonedmg);
            }
            else
            {
                _auds.PlayWallSFX();
            }

            if (_isparry == true)
            {
                _auds.PlayParrySFX();

               

            }



        }

        

    }

    
}
