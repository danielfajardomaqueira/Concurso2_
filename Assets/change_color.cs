using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class change_color : MonoBehaviour
{

    public GameObject Bola;
    public Material material;



    public void ChangeColorRed()
    {
        material.color = Color.red;
        Bola.GetComponent<Renderer>().material.color = Color.red;
    }

    public void ChangeColorGreen()
    {
        material.color = Color.green;
        Bola.GetComponent<Renderer>().material.color = Color.green;
    }

    public void ChangeColorBlue()
    {
        material.color = Color.blue;
        Bola.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Awake()
    {
        //Bola.GetComponent<Renderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Bola.GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
