using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloklar : MonoBehaviour {

    public static int KirilabilirBlokSayisi = 0;
    private int VurulmaSayisi;
    private SahneKontrolu SahneYoneticisi;
    public Sprite[] BlokGorunumleri;
    bool KirilabilirMi;
    public GameObject efekt;

    void Start() {
        KirilabilirMi = (this.tag == "Kirilabilir");
        if (KirilabilirMi)
        {
            KirilabilirBlokSayisi++;
            
        }

        VurulmaSayisi = 0;
        SahneYoneticisi = GameObject.FindObjectOfType<SahneKontrolu>();
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();

        if (KirilabilirMi)
        { 
            VurulmaKontrolu();
        }
    }

    public void VurulmaKontrolu()
    {
        int Can;
        Can = BlokGorunumleri.Length + 1;
        VurulmaSayisi++;
        if (VurulmaSayisi >= Can)
        {
            KirilabilirBlokSayisi--;
            Destroy(gameObject);
            EfektiOlustur();
            SahneYoneticisi.BloklarinYokOlması();
        }
        else
        {
            BlokGoruntusunuDegistir();
        }
    }

    void EfektiOlustur()
    {
        GameObject Efektimiz = Instantiate(efekt, gameObject.transform.position, Quaternion.identity) as GameObject;
        Efektimiz.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
    }

    public void BlokGoruntusunuDegistir()
    {
        this.GetComponent<SpriteRenderer>().sprite = BlokGorunumleri[VurulmaSayisi - 1];
    }

    public void SonrakiSahne()
    {
        SahneYoneticisi.SonrakiSahne();
    }
}
