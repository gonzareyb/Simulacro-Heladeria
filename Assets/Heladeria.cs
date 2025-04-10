using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string SaborHelado;
    public int CantidadGramos;
    float Precio;
    
    // Start is called before the first frame update
    void Start()
    {

        if (SaborHelado != "DDL" && SaborHelado != "CHO" && SaborHelado != "FRU")
        {
            Debug.Log("Codigo no valido");
            return;
        }

        if (CantidadGramos < 250 || CantidadGramos > 3000)
        {
            Debug.Log("cantidad e helado no valida");
            return;
        }

        Precio = CantidadGramos * (500 / 1000.0f);

        if (SaborHelado == "FRU")
        {
            Precio = Precio - Precio * 0.1f;
        }

        Debug.Log("debe abonar " + Precio);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


