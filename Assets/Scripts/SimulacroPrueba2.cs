using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroPrueba2 : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;
    public int presupuesto;
    // Start is called before the first frame update
    void Start()
    {
        int compra = producto1 + producto2 + producto3;
        int total = presupuesto - compra;
        int falta = compra - presupuesto;
        if (presupuesto>compra)
        {
            Debug.Log("Todavia le queda dinero y le seobra " + total);
            
        }
        else
        {
            Debug.Log("La compra supera el presupuesto y le falta " + falta);

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
