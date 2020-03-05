using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text Score_t;
    public int counter = 1;
  public int score = 0;
public void OnClick()
    {
        score += counter;
        Score_t.text = score.ToString()+" Bitcoins";
    }  

}
