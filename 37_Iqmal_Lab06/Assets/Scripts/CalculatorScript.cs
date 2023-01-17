using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public float Amount;
    public float SGDRM = 3.27f;
    public float SGDIDR = 11447.60f;

    public Toggle RM;
    public Toggle IDR;

    public InputField InputAmount;
    public InputField InputConverted;

    // Start is called before the first frame update
    void Start()
    {
        RM.isOn = false;
        IDR.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Conversion()
    {
        float Amount = float.Parse(InputAmount.text);

        if(RM.isOn == true)
        {
            IDR.isOn = false;

            InputConverted.text = "RM " + (Amount * SGDRM);
        }
        else if(IDR.isOn == true)
        {
            RM.isOn = false;

            InputConverted.text = "Rupiah " + (Amount * SGDIDR);
        }
    }

    public void Clear()
    {
        RM.isOn = false;
        IDR.isOn = false;

        InputAmount.text = " ";
        InputConverted.text = " ";
    }
}
