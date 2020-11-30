using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunBariKontrolu : MonoBehaviour {


    public bool OtomatikOynama = false;
    private OyunTopuKontrolu OyundakiTop;

    private void Start()
    {
        OyundakiTop = GameObject.FindObjectOfType<OyunTopuKontrolu>();
    }

    void Update () {
        if (OtomatikOynama)
        {
            OtomatikHaraket();
        }
        else
        {
            FaremizleHaraket();
        }
              
        
	}

    void FaremizleHaraket()
    {
        Vector3 OyunBariKonumu = new Vector3(0f, this.transform.position.y, 0f);
        float MouseKonumX = Input.mousePosition.x / Screen.width * 16;
        OyunBariKonumu.x = Mathf.Clamp(MouseKonumX, 1f, 15f);
        this.transform.position = OyunBariKonumu;
    }


    
    void OtomatikHaraket()
    {
        Vector3 OyunBariKonumu = new Vector3(0f, this.transform.position.y, 0f);
        Vector3 TopunKonumu = OyundakiTop.transform.position;
        OyunBariKonumu.x = Mathf.Clamp(TopunKonumu.x, 1f, 15f);
        this.transform.position = OyunBariKonumu;
    }
    
}
