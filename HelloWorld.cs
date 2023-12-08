using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //int count = 0;
    [SerializeField] TextMeshProUGUI countT;
    [SerializeField] List<string> text_variables = new();

    [System.Obsolete]
    public void Click()
    {
        countT.text = text_variables[Random.RandomRange(0, text_variables.Count)];
    }
}
