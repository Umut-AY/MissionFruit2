using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManeger : MonoBehaviour
{
    public Text totalFruit;
    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalFruit.text = transform.childCount.ToString();
        fruitControl();
    }
    public void fruitControl()
    {
        if (transform.childCount <= 0)
        {
            end.SetActive(true);
        }
    }
}
