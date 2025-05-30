using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Contacto con " + collision.gameObject.name); //imprime en consola el nombre del objeto con el que colisiona
		Destroy(gameObject); //destruye el objeto que tiene este script
		Destroy(collision.gameObject); //destruye el objeto con el que colisiona
	}
}
