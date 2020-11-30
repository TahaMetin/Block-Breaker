using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyununBaşarisizSonlanmasi : MonoBehaviour {

    private SahneKontrolu Yonetici;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Yonetici = GameObject.FindObjectOfType<SahneKontrolu>();
        Yonetici.SahneyeYonlen("Kaybetme");
    }
}
