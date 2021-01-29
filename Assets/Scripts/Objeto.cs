using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public Light luz;
    public Color cor;
    public bool estadoAtual = false;



    void Awake()
    {
        luz = GetComponent<Light>();
    }

    void Start()
    {
        luz.range = 0;
        luz.color = cor;
    }

    public void Proximidade(bool estado)
    {
        print("Proximidade: " + estado);
        estadoAtual = estado;
        if (estado)
        {
            print("Play");
            StartCoroutine(Pulsar());
        }

    }

    IEnumerator Pulsar()
    {
        while (estadoAtual)
        {
            while (luz.range <= 3)
            {
                luz.range += .2f;
                print(luz.range);
                yield return new WaitForSeconds(.1f);
            }
            luz.range = 3;
            yield return new WaitForSeconds(1f);
            while (luz.range > 0)
            {
                luz.range -= .2f;
                print(luz.range);
                yield return new WaitForSeconds(.1f);
            }
            luz.range = 0;
        }
        print("Acabou essa porcaria");
    }
}