using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScriptWork1 : MonoBehaviour
{
    [SerializeField] private List<int> OrnekList;
    [SerializeField] private int[] ornekDiziler2;





    private void Start()
    {

        int[] numbers = new int[72]; // 6'dan 77'ye kadar 72 tane elemana sahibiz
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 6;
        }

        string arrayElements = "";
        string doubles = "";
        string third = "";
        string fourth = "";
        string fifth = "";

        foreach (int number in numbers)
        {
            arrayElements += number + " - ";
            if (number % 2 == 0)
                doubles += number + " - ";
            if (number % 3 == 0)
                third += number + " - ";
            if (number % 4 == 0)
                fourth += number + " - ";
            if (number % 5 == 0)
                fifth += number + " - ";
        }

        Debug.Log(arrayElements);
        Debug.Log(doubles);
        Debug.Log(third);
        Debug.Log(fourth);
        Debug.Log(fifth);

    }

    private void Update()
        {
            Dictionary<int, string> examples = new Dictionary<int, string>();
            examples.Add(1, "mom");
            examples.Add(2, "dad");
            examples.Add(3, "brother");

            foreach (var VARIABLE in examples)
            {
                Debug.Log(VARIABLE);
            }

            string value = examples[1];
            Debug.Log(value);

            string lesson = examples.FirstOrDefault(x => x.Key == 2).Value;
            Debug.Log(lesson);

        }
}
