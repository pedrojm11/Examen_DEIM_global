using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crearbolas : MonoBehaviour
{
    [SerializeField] GameObject Huevo;
    [SerializeField] Transform RefPos;
    [SerializeField] float distobstacle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Huevoscorrutine");
        
    }

    // Update is called once per frame
    void Update()
    {
        CrearHuevo();
    }
    void CrearHuevo()
    {
        //Crear una variable para que genere un numero aleatorio entre los dos rangos que le asigno
        float posRandom = Random.Range(0f, 30f);
        //Creas un nuevo vector que va a ser el destino donde se genere la columna, el posramdom al principio debido a que queremos que se genere en el eje x en el centro seria el eje y , z en ultimo lugar
        Vector3 DestPos = new Vector3(posRandom, posRandom, posRandom);
        //Este vector coge la posicion de referencia y le añade ese vector aleatorio
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(Huevo, NewPos, Quaternion.identity);
    }
    IEnumerator HuevosCorrutine()
    {
        //for(puntodeinicio,condicion,accionfinal) este bucle nos sirve para crear la columna cada x tiempo
        for (int n = 0; ; n++)
        {
            //para ver las columnas que estoy generando
            print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn); esto solo es necesario si me pide que lo cree en 0,0,0
            //aqui como queremos que se genere en la posicion ramdom asignamos el metodo que hemos creado para que haga esto
            CrearHuevo();
            //Dentro del for hacemos un yield return que basicamente es decirle al for que pare antes de volver hacerse
            yield return new WaitForSeconds(1);
        }
    }
}
