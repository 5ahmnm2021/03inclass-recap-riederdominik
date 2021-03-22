using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionScript : MonoBehaviour
{
    public InputField if1;
    public InputField if2;
    public Text sum;

    bool num1 = true;
    bool num2 = true;
    
    public void Addition()
    {
        float if1Float = 0;
        float if2Float = 0;

        string errorMessage = "Geben Sie eine gültige Zahl ein";

        try
        {
            if1Float = float.Parse(if1.text);
            if1.image.color = Color.white;
            num1 = true;
        }
        catch (System.Exception)
        {
            if1.image.color = Color.red;
            if1.text = errorMessage;
            num1 = false;
        }

        try
        {
            if2Float = float.Parse(if2.text);
            if2.image.color = Color.white;
            num2 = true;
        }
        catch (System.Exception)
        {
            if2.image.color = Color.red;
            if2.text = errorMessage;
            num2 = false;
        }

        if(num1 && num2)
        {
            sum.text = (if1Float + if2Float).ToString();
            Debug.Log("Die Addition ergibt: " + sum.text);
        }
    }
}
