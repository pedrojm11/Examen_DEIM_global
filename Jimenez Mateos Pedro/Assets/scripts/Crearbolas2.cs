using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Crearbolas2 : MonoBehaviour
{

    [SerializeField] GameObject bolas;
    [SerializeField] Transform InitPos;
    [SerializeField] Text numGlobos;
    public int cache;
    // Start is called before the first frame update
    void Start()
    {
        InicioBolas();
        StartCoroutine("bolasCorrutina");
    }

    // Update is called once per frame
    void Update()
    {
        contarNaves();
    }
    void InicioBolas()
    {

        for (cache = 0; cache < 20; cache++)
        {
            float posRandomx = Random.Range(-40f, 40f);
            float posRandomz = Random.Range(-40f, 40f);
            float posRandomy = Random.Range(0f, 10f);
            Vector3 NewPos = new Vector3(posRandomx, posRandomy, posRandomz);
            Vector3 finalPos = InitPos.position + NewPos;
            Instantiate(bolas, finalPos, Quaternion.identity);
        }

    }
    void generarBolas()
    {
        float posRandomx = Random.Range(-40f, 40f);
        float posRandomz = Random.Range(-40f, 40f);
        float posRandomy = Random.Range(0f, 10f);
        Vector3 NewPos = new Vector3(posRandomx, posRandomy, posRandomz);
        Instantiate(bolas, NewPos, Quaternion.identity);
    }
    IEnumerator bolasCorrutina()
    {
        for (; cache <= 24; cache++)
        {
            generarBolas();
            yield return new WaitForSeconds(4);
        }
        for (cache = 25; cache <= 30; cache++)
        {
            generarBolas();
            yield return new WaitForSeconds(2);
        }
        for (cache = 31; ; cache++)
        {

            generarBolas();
            yield return new WaitForSeconds(0.5f);
        }
    }
    void contarNaves()
    {
        numGlobos.text = "Globos: " + cache;
    }
}
