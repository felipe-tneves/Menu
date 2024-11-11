using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDeEstudo : MonoBehaviour
{
    int[] numeros = { 3, 5, 7, 2, 8, 1 };
    int maior = 0;

    void Start()
    {
        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        print("O maior número é: " + maior);
    }


}
