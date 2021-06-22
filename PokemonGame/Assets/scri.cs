using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{

   Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movement * 2 * Time.deltaTime;

        if(Input.GetAxis("Vertical") < 0f ) {
            anim.SetBool("andar_frente",true);
            //transform.eulerAngles = new Vector3 (0f,0f,0f);
        }

        if(Input.GetAxis("Vertical") < 0f ) {
            anim.SetBool("andar_frente",true);
            //transform.eulerAngles = new Vector3 (0f,180f,0f);
        }

        if(Input.GetAxis("Vertical") == 0f ) {
            anim.SetBool("andar_frente",false);
        }

        ///
        if(Input.GetAxis("Horizontal") > 0f ) {
            anim.SetBool("andar_direita",true);
            //transform.eulerAngles = new Vector3 (0f,0f,0f);
        }

        if(Input.GetAxis("Horizontal") > 0f ) {
            anim.SetBool("andar_direita",true);
           // transform.eulerAngles = new Vector3 (0f,180f,0f);
        }



       if(Input.GetAxis("Horizontal") == 0f ) {
           anim.SetBool("andar_direita",false);
       }

        
       if(Input.GetAxis("Horizontal") < 0f ) {
          anim.SetBool("andar_esquerda",true);
            //transform.eulerAngles = new Vector3 (0f,0f,0f);
        }

        if(Input.GetAxis("Horizontal") < 0f ) {
            anim.SetBool("andar_esquerda",true);
            //transform.eulerAngles = new Vector3 (0f,180f,0f);
        }

        if(Input.GetAxis("Horizontal") == 0f ) {
            anim.SetBool("andar_esquerda",false);
        }

        ///
        if(Input.GetAxis("Vertical") > 0f ) {
            anim.SetBool("andar_costas",true);
            //transform.eulerAngles = new Vector3 (0f,0f,0f);
        }

        if(Input.GetAxis("Vertical") > 0f ) {
            anim.SetBool("andar_costas",true);
            //transform.eulerAngles = new Vector3 (0f,0f,0f);
        }

        if(Input.GetAxis("Vertical") == 0f ) {
            anim.SetBool("andar_costas",false);
        }
    }


}