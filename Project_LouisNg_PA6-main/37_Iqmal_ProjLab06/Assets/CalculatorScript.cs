using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public float Amount;

    //Iqmals Currency
    public float SGDRM = 3.27f;
    public float SGDIDR = 11447.60f;

    public Toggle RM;
    public Toggle IDR;

    //Louis's Currency
    public Toggle JPY;
    public Toggle TRY;

    public float SGDJPY = 97.39f;
    public float SGDTRY = 14.21f;

    //Syafiq Currency
    public float SGDUSD = 0.76f;
    public float SGDEUR = 0.63f;

    public Toggle USD;
    public Toggle EUR;

    public InputField InputAmount;
    public InputField InputConverted;

    // Start is called before the first frame update
    void Start()
    {
        //Iqmals Code
        RM.isOn = false;
        IDR.isOn = false;
        

        //Syafiq Code
        USD.isOn = false;
        EUR.isOn = false;

        //Louis Code
        JPY.isOn = false;
        TRY.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Conversion()
    {
        float Amount = float.Parse(InputAmount.text);

        //Iqmals Code
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
        

        //Syafiq Code
        if (USD.isOn == true)
        {
            EUR.isOn = false;

            InputConverted.text = "$ " + (Amount * SGDUSD);
        }
        else if (EUR.isOn == true)
        {
            USD.isOn = false;

            InputConverted.text = "£ " + (Amount * SGDEUR);
        }

        //Louis Code
        if (JPY.isOn == true)
        {
            TRY.isOn = false;

            InputConverted.text = "¥" + (Amount * SGDJPY);
        }
        if (TRY.isOn == true)
        {
            JPY.isOn = false;

            InputConverted.text = "₺" + (Amount * SGDTRY);
        }
    }

    public void Clear()
    {
        RM.isOn = false;
        IDR.isOn = false;
        USD.isOn = false;
        EUR.isOn = false;
        JPY.isOn = false;
        TRY.isOn = false;

        InputAmount.text = " ";
        InputConverted.text = " ";
    }

}
