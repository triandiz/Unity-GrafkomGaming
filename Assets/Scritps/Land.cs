using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{
    public GameObject AndaGagal;
    
    void Start()
    {
		AndaGagal.gameObject.SetActive(false);
	}
	
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Box")
        {
			AndaGagal.gameObject.SetActive(true);
			Time.timeScale = 0;
		}
    }
}
