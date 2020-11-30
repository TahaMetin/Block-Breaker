using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunTopuKontrolu : MonoBehaviour {

    public OyunBariKontrolu OyunBari;
    private bool OyunBasladiMi;
    private Vector3 TopIleBarArasındakiMesafe;
    
	void Start () {
        TopIleBarArasındakiMesafe = this.transform.position - OyunBari.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        if (!OyunBasladiMi)
        {
            this.transform.position = OyunBari.transform.position + TopIleBarArasındakiMesafe;

            if (Input.GetMouseButtonDown(0))
            {
                OyunBasladiMi = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(7f, 10f);
            }
        }

        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 UfakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
        if (OyunBasladiMi)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += UfakSapma;
        }
        
    }

}
