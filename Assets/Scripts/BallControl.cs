using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


// Problem-2 Dan 3_Resolving
public class BallControl : MonoBehaviour
{

    // Method Rigibody
    private Rigidbody2D BadanObjek2D;

    // Mengatur Nilai Arah X 
    public float xInitialForce;

    // Mengatur Nilai Arah y
    public float yInitialForce;

    void MengaturUlangBola()
    {
        // Mengatur Ulang Posisi
        transform.position = Vector2.zero;
        //reset velocity
        BadanObjek2D.velocity = Vector2.zero;
    }

    void DoronganBola()
    {
        // Membuat Nilai Y
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Mengacak Titik
        float randomDirection = Random.Range(0, 2);

        // Biar Arah Bola Random
        if (randomDirection < 1.1f)
        {
            BadanObjek2D.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
        }
        else
        {
            BadanObjek2D.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
        }
    }

    // Method Mulai Ulang Game
    void MulaiUlangGame()
    {
        // Atur Ulang Posisi Bola
        MengaturUlangBola();
        // Mendapatkan Method Invoke
        Invoke("DoronganBola", 2);
    }

    void Start()
    {
        // Mendapatkan Komponen Rigibody
        BadanObjek2D = GetComponent<Rigidbody2D>();

        // Memulai Game
        MulaiUlangGame();
    }

    // Andreas Marbun
    // :D


    // Penambahan Comments Untuk Resolving Ke-3
}
