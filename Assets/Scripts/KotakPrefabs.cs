using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class KotakPrefabs : MonoBehaviour
{
    public float Darah = 50f;

    public UnityAction<GameObject> YourDeath = delegate { };

    private bool KenaSeranganMental = false;

    void OnDestroy()
    {
        if (KenaSeranganMental)
        {
            YourDeath(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        // Game Tag Bola
        if (col.gameObject.tag == "Bola")
        {
            PengaturanSkors.Instance.SkorSings();
            this.gameObject.SetActive(false);
            // Ketika Objek Bola Mengenai Kotak, Kotak Akan Dihancurkan Dan Player Memndapatkan 1 Skors
            Destroy(this.gameObject, 1);
        }
        else if (col.gameObject.tag == "Tembok")
        {
            // Menghintung Damage Yang Diterima
            float KenaDamageDanMental = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            Darah -= KenaDamageDanMental;

            if (Darah <= 0)
            {
                KenaSeranganMental = true;
                Destroy(gameObject);
            }
        }
    }
}
