using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionScript : MonoBehaviour
{
    public InputField if1;
    public InputField if2;
    public Text sum;

    public void Addition()
    {
        int if1Int = int.Parse(if1.text);
        int if2Int = int.Parse(if2.text);

        int sumInt = if1Int + if2Int;

        sum.text = sumInt.ToString();

        Debug.Log("Die Addition ergibt: " + sum.text);
    }
}
