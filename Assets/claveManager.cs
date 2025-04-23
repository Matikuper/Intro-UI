using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class claveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    string clave = "Tic2025";

    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        if(claveIngresada != clave)
        {
            txtMensaje.text = "Acceso Denegado";
            inputClave.text = string.Empty;
        }
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
