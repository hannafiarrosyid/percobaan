using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //these variable change our movement speed
    [SerializeField] float moveSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        Instruksi();
    }

    // Update is called once per frame
    void Update()
    {
        Bergerak();
    }
    
    void Instruksi(){
        Debug.Log("selamat datang");
        Debug.Log("mobilitas menggunakan wasd");
        Debug.Log("jangan menabrak tembok");
    }

    void Bergerak(){
        float xValue =Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue =Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
