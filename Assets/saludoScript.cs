using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class saludoScript : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreUsuario;
    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = "";
    }
    public void saludar()
    {
        txtSaludo.text = "Hola " + inputNombre.text;
    }
}
