using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class müzikoynatma : MonoBehaviour {

    static müzikoynatma TekMüzikOynatıcısı = null;
	// Use this for initialization
	void Awake () {
        if (TekMüzikOynatıcısı != null)
        {
            Destroy(gameObject);
        }
        else
        {
            TekMüzikOynatıcısı = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
