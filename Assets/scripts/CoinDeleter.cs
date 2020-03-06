using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDeleter : MonoBehaviour
{
    public GameObject Coin;
    void Update()
    {
       if(Coin.transform.position.y < (-2-Screen.height/100)) {
            Destroy(Coin);
        }
    }
}
