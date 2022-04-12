using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioExamen : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;
    public int precio1;
    public int precio2;
    public int precio3;
    public int cantidad1;
    public int cantidad2;
    public int cantidad3;
    // Start is called before the first frame update
    void Start()
    {
        int total;
        float montofinal;
        int precioxc1;
        int precioxc2;
        int precioxc3;
        float totaldescuento;
        float descuento1;
        float descuento2;
        float descuento3;
        float totald1=0;
        float totald2=0;
        float totald3=0;

        if (precio1 < 1)
        {
            Debug.Log("Error, el precio es incorrecto");
        }
        else
        {
            Debug.Log("El precio es correcto, se puede continuar");
        }
        if (precio2 < 1)
        {
            Debug.Log("Error, el precio es incorrecto");
        }
        else
        {
            Debug.Log("El precio es correcto, se puede continuar");
        }
        if (precio3 < 1)
        {
            Debug.Log("Error, el precio es incorrecto");
        }
        else
        {
            Debug.Log("El precio es correcto, se puede continuar");
        }
        if (cantidad1 < 1)
        {
            Debug.Log("Error, la cantidad es incorrecta");
        }
        else
        {
            Debug.Log("la cantidad es correcto, se puede continuar");
        }
        if (cantidad2 < 1)
        {
            Debug.Log("Error, la cantidad es incorrecta");
        }
        else
        {
            Debug.Log("la cantidad es correcto, se puede continuar");
        }
        if (cantidad3 < 1)
        {
            Debug.Log("Error, la cantidad es incorrecta");
        }
        else
        {
            Debug.Log("la cantidad es correcto, se puede continuar");
        }

        precioxc1 = cantidad1 * precio1;
        precioxc2 = cantidad2 * precio2;
        precioxc3 = cantidad3 * precio3;
        total = precioxc1 + precioxc2 + precioxc3;

        if (cantidad1 > 3)
        {
            descuento1 = precioxc1 * 0.2f;
            totald1 = precioxc1 - descuento1;
        }
        else
        {
            Debug.Log("No hay descuento posible para este producto, debe comprar mas de 3 para tener descuento");
        }
        if (cantidad2 > 3)
        {
            descuento2 = precioxc2 * 0.2f;
            totald2 = precioxc2 - descuento2;
        }
        else
        {
            Debug.Log("No hay descuento posible para este producto, debe comprar mas de 3 para tener descuento");
        }
        if (cantidad3 > 3)
        {
            descuento3 = precioxc3 * 0.2f;
            totald3 = precioxc3 - descuento3;
        }
        else
        {
            Debug.Log("No hay descuento posible para este producto, debe comprar mas de 3 para tener descuento");
        }

        totaldescuento = totald1 + totald2 + totald3;
        montofinal = total - totaldescuento;

        Debug.Log("Sus productos " + producto1 + producto2 + producto3 + " tienen un valor total de " + total + " Se desconto " + totald1 + " de " + producto1 + "," + totald2 + " de " + producto2 + " y " + totald3 + " de " + producto3 + ". El monto total con los descuentos aplicados es de $" + montofinal);
        
        // Update is called once per frame
        void Update()
        {

        }
    }
}
