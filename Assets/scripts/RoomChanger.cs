using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomChanger : MonoBehaviour
{
    public Text Room;
    public GameObject Camera;
    public GameObject Panel;
    public GameObject Clicker;
    public Sprite Potato;
    public Sprite Mac;
    public Sprite Farm;
    void Update()
    {
       if(Camera.GetComponent<Game>().score > 100 && Camera.GetComponent<Game>().counter <= 1)
        {
            Room.text = "You are mining on hakuna potato PC";
            Camera.GetComponent<Game>().counter = 2;
            Camera.GetComponent<Game>().score -= 80;
            Panel.GetComponent<Image>().sprite = Potato;
        }
        if (Camera.GetComponent<Game>().score > 200 && Camera.GetComponent<Game>().counter <= 2)
        {
            Room.text = "You are mining on your mom's macbook";
            Camera.GetComponent<Game>().counter = 3;
            Camera.GetComponent<Game>().score -= 160;
            Panel.GetComponent<Image>().sprite = Mac;
        }
        if (Camera.GetComponent<Game>().score > 300 && Camera.GetComponent<Game>().counter <= 3)
        {
            Room.text = "You are mining on your own farm of bitcoins";
            Camera.GetComponent<Game>().counter = 5;
            Camera.GetComponent<Game>().score -= 300;
            Panel.GetComponent<Image>().sprite = Farm;
        }

    }
}
