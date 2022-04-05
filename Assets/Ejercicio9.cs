using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    // Start is called before the first frame update

    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capital1;
    public float capital2;
    public float capital3;

    float capitalTotal;
    float porc1;
    float porc2;
    float porc3;

    void Start()
    {
        Debug.Log("Nombre: " + nombre1 + ", capital: " + capital1 + ", porcentaje: %" + porc1 + ", total: " + capitalTotal);
        Debug.Log("Nombre: " + nombre2 + ", capital: " + capital2 + ", porcentaje: %" + porc2 + ", total: " + capitalTotal);
        Debug.Log("Nombre: " + nombre3 + ", capital: " + capital3 + ", porcentaje: %" + porc3 + ", total: " + capitalTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
