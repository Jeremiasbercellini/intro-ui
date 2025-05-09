using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class sumaUI : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    int num1;
    int num2;
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";

    }
    public void sumarYmostrar()
    {
        num1 = int.Parse(inputNum1.text);
        num2 = int.Parse(inputNum2.text);
        txtResultado.text = (num1 + num2).ToString();
    }
}
