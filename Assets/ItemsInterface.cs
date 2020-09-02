using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsInterface : MonoBehaviour
{
    static int collected = 0;
    //public GameObject collectorUI;
    public Text numText;
    bool instantiated = false;

    /*    public ItemsInterface()
        {
            //collectorUI = new GameObject("StuffUI");
            //numText = collectorUI.AddComponent<Text>();
        }
     */

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ItemsInterface started");
    }

    void Update()
    {
        Debug.Log("ItemsInterface update");
        /*if (instantiated)
        {
            numText.text = collected.ToString();
        }*/
    }
    public static void Increase()
    {
        collected++;
    }

    public void SetInstantiated(Text txt)
    {
        instantiated = true;
        //numText = txt;
        //numText.text = collected.ToString();

    }
}
