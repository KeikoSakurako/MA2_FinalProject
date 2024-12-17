using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Soucre-----")]
    [SerializeField] AudioSource _masterSource;
    [SerializeField] AudioSource _musiceSource;
    [SerializeField] AudioSource _sfxSource;

    [Header("-----Backgroung Clip-----")]
    public AudioClip _background;

    [Header("Limbo")]
    public AudioClip _preLimbo;
    public AudioClip _excetuteLimbo;
    public float _timeIt;

    [Header("-----UI Clip-----")]
    public AudioClip _confirm;
    public AudioClip _hover;
    public AudioClip _back;
    public AudioClip _pause;

    [Header("-----Game SFX-----")]
    public AudioClip _lifedmg;
    public AudioClip _break;
    public AudioClip _block;
    public AudioClip _wall;
    public AudioClip _parry;

   

    private void Start()
    {
        _musiceSource.clip = _background;
        _musiceSource.Play();

    }

    public void PlaySFX(AudioClip clip)
    {
        
        _sfxSource.PlayOneShot(clip);
    }

    public void PlayParrySFX()
    {

        _sfxSource.PlayOneShot(_parry);
    }

    public void PlayBlockHitSFX()
    {

        _sfxSource.PlayOneShot(_block);
    }

    public void PlayWallSFX()
    {

        _sfxSource.PlayOneShot(_wall);
    }

    public void PlayBreakSFX()
    {

        _sfxSource.PlayOneShot(_break);
    }

    public void PlayLifeSFX()
    {

        _sfxSource.PlayOneShot(_lifedmg);
    }

    public void PlayConfirmSFX()
    {

        _sfxSource.PlayOneShot(_confirm);
    }

    public void PlayBackSFX()
    {

        _sfxSource.PlayOneShot(_back);
    }

    public void Limbo()
    {

        StartCoroutine(ReadyState());
    }

    IEnumerator ReadyState()
    {
        _musiceSource.clip = _preLimbo;
        _musiceSource.Play();

        yield return new WaitForSeconds(_timeIt);
        _musiceSource.clip = _excetuteLimbo;
        _musiceSource.Play();

    }

}
