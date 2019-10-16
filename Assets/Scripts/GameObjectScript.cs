using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    private Coroutine coRoutinePrintHello;
    private Coroutine coRoutinePrintNums;


    private IEnumerator Hello()
    {
        WaitForSeconds wfs = new WaitForSeconds(4);
        while (true)
        {
            yield return wfs;
            Debug.Log("Hello");
        }
    }

    private IEnumerator PrintNums()
    {
        int counter = 0;
        WaitForSeconds wfs = new WaitForSeconds(1);
        while (true)
        {
            if (counter > 30) StopCoroutine(coRoutinePrintHello);
            Debug.Log(counter);
            counter++;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        coRoutinePrintHello = StartCoroutine(Hello());
        coRoutinePrintNums = StartCoroutine(PrintNums());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
