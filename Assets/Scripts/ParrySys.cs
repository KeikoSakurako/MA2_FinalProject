using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrySys : MonoBehaviour
{

    [SerializeField] GameObject _parry;

    [SerializeField] float _parryTime = 2f;

    public void Parry()
    {
        StartCoroutine(CounterParry());
    }

    public IEnumerator CounterParry()
    {

        Debug.Log("Parry");
       
        _parry.SetActive(true);
        yield return new WaitForSeconds(_parryTime);

        Debug.Log("No Parry");
        _parry.SetActive(false);

    }
}
