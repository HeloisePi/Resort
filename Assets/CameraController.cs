using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    public Transform player;
    public int Perdu = 0;

    void Update()
    {
        // Fait défiler la caméra vers le haut
        transform.position += new Vector3(0, scrollSpeed * Time.deltaTime, 0);

        // Vérifie si le personnage est sorti du champ de la caméra
        if (player.position.y < (transform.position.y - Camera.main.orthographicSize))
        {
          if(Perdu == 0)
          {
            Perdu = 1;
            Debug.Log("Perdu !");
          }
        }
    }
}
