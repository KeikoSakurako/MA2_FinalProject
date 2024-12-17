using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGeneration : MonoBehaviour
{

    public Vector2Int _size;
    public Vector2 _offset;
    public GameObject _brickPreFab;


    private void Awake()
    {
        for (int i = 0; i < _size.x; i++)
        {
            for (int j = 0; j < _size.y; j++)
            {
                Debug.Log("SpawnBricks");
                GameObject newbrick = Instantiate(_brickPreFab, transform);
                newbrick.transform.position = transform.position + new Vector3((float)((_size.x - 1) * 0.5f - i) * _offset.x, j * _offset.y, 0);
            }
        }


    }

    public void SetNewGeneration()
    {
        for (int i = 0; i < _size.x; i++)
        {
            for (int j = 0; j < _size.y; j++)
            {
                Debug.Log("SpawnBricks");
                GameObject newbrick = Instantiate(_brickPreFab, transform);
                newbrick.transform.position = transform.position + new Vector3((float)((_size.x - 1) * 0.5f - i) * _offset.x, j * _offset.y, 0);
            }
        }
    }

}
