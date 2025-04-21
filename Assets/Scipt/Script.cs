using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreIngresado;
    string saludo;

    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        //obtener el nombre del inputfield

        nombreIngresado = inputNombre.text;

        //concatenar el nombre con un saludo

        saludo = "Hola " + nombreIngresado + "!";

        //mostrar el saludo en txtSaludo

        txtSaludo.text = saludo;
    }
}
