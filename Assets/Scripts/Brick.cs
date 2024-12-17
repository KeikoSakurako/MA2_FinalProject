using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] int _life;
    [SerializeField] int _damage;
    [SerializeField] SpriteRenderer _spr;
    [SerializeField] Sprite[] _states;


    private void Start()
    {
        _life = _states.Length;
        _spr.sprite = _states[_life - 1];
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.CompareTag("Player"))
        {
            
            Takedmg(_damage);
            FindAnyObjectByType<AudioManager>().PlayBlockHitSFX();

            
        }
    }


    public void Takedmg(int dmg)
    {
        _life -= dmg;
        //playmusic
        if (_life <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Brick Destroy");
            FindAnyObjectByType<LevelManager>()._breakCounter++;
            FindAnyObjectByType<AudioManager>().PlayBreakSFX();
        }
        else 
        {
           
            _spr.sprite = _states[_life - 1];
        }

    }

}
