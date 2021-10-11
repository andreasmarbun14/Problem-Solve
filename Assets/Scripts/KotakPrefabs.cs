using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class KotakPrefabs : MonoBehaviour
{
    public float Darah = 50f;

    public UnityAction<GameObject> YourDeath = delegate { };

    private bool _isHit = false;

    void OnDestroy()
    {
        if (_isHit)
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
            _isHit = true;
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Tembok")
        {
            // Menghintung Damage Yang Diterima
            float KenaDamageDanMental = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            Darah -= KenaDamageDanMental;

            if (Darah <= 0)
            {
                _isHit = true;
                Destroy(gameObject);
            }
        }
    }
}
