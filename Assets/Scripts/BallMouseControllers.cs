using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class BallMouseControllers : MonoBehaviour
{
    // Method Player Body
    private Rigidbody2D Pemainrigidbody2D;

    // Method Camera
    public Camera Kamera_Utama;

    // Method Kecepatan
    public float Kecepatan;

    
    private void Start()
    {
        // Mendapatkan Method Rigibody
        Pemainrigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Mengatur Kecepatan Untuk Menuju Mouse Kursor
        Vector3 MousePlayer = Kamera_Utama.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        Vector3 angle = MousePlayer - transform.position;
        // Andreas Marbun
        // Scripts
        // Method Jika Mouse Bergerak Maka Benda Akan Mengikuti Kursor Tersebut
        if (Vector3.Distance(MousePlayer, transform.position) > 0.5)

        {
            transform.Translate(angle.normalized * Kecepatan * Time.deltaTime);
        }


    }

    // :D
    // :)
    // Akhirnya Bisa :D
}
