using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caja : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        Movercubo();
    }
    void Movercubo()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float DesplazamientoZ = Input.GetAxis("Vertical");
        float DesplazamientoX = Input.GetAxis("Horizontal");
        if (posX < 184 && posX > -184 || posX < -184 && DesplazamientoX > 0 || posX > 184f && DesplazamientoX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * DesplazamientoX);
        }

        if (posZ < 184 && posZ > -184 || posZ < 184 && DesplazamientoZ > 0 || posZ > -184f && DesplazamientoZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * DesplazamientoZ);

        }
    }
}
