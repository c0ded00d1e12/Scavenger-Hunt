using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq.Expressions;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public ItemsInterface collectInstance;
    public Text numText;
    GameObject TxtGObject;

    public GameData()
    {
        collectInstance = new ItemsInterface();
    }

    // Start is called before the first frame update
    void Start()
    {
        //CollectorInterface collectInstance = new CollectorInterface();
        Debug.Log("GameData in GameState started");


       TxtGObject = GameObject.Find("CollectorText");
        Debug.Log(TxtGObject.ToString());
       //numText = TxtGObject.AddComponent<Text>();
       //collectInstance.SetInstantiated(numText);
    }

    public void Collect(GameObject item)
    {
        item.SetActive(false);
        ItemsInterface.Increase();
    }
}
