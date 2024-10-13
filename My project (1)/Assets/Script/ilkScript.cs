using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkScript : MonoBehaviour
{
   // [SerializeField]

   // private float speed = 5f;
    // Start is called before the first frame update
    //public Vector3 newPozisyon = new Vector3(0,5,0);
    public float speed = 5f;
    void Start()
    {
        //transform.position = newPozisyon;
    }
   
    
    
    // Update is called once per frame
    void Update()
    {
       //float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
       
        transform.Translate(new Vector3(1,0,0)*horizontalInput*speed*Time.deltaTime);
       //transform.Translate(new Vector3(0, 1, 0) * verticalInput  * speed * Time.deltaTime);
    }
}
