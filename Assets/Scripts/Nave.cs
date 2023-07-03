using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float velocidade = 0.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;  
    public GameObject tiro1 ;
    public float tempoDeDisparo = 0.3f ;
    public float podeDisparar = 0.0f ;
    public bool possoDarDisparoTriplo = false ;
    public GameObject disparoTriplo ;

    //Start is called before the first frame update
    void Start()
  {
     Debug.Log("Metodo Start de  " + this.name);
     velocidade = 5.0f ;
     transform.position = new Vector3(-7,0,0);
  }

    // Update is called once per frame
    void Update()
    {
        Movimento();

        if (Input.GetKeyDown(KeyCode.Space)){

            if ( Time.time > podeDisparar ){

               if (possoDarDisparoTriplo == true ){

                   Instantiate(disparoTriplo,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);

               } else {

                   Instantiate(tiro1,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);
               }






                podeDisparar = Time.time + tempoDeDisparo ;
            }
 
        }

   }

private void Movimento(){

       entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*velocidade*entradaHorizontal);
        

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*velocidade*entradaVertical);

        if ( transform.position.y  > 6.0f ) {
            transform.position = new Vector3(transform.position.x,-6.0f,0);
        }

        if ( transform.position.y  < -6.0f  ) {
            transform.position = new Vector3(transform.position.x,6.0f,0);
        }
   }



}





 





   