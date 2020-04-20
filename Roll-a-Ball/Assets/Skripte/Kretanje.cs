using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Kretanje : MonoBehaviour
{

    //Deklaracija varijable za brzinu
    public Text countText;
    public float speed;
    private int zbroj;
    private Rigidbody rb;
  

    private void Start()
    {
        //dohvacanje 
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    private void FixedUpdate()
    {
        //dohvacanje vrijednosti osi
        float kretanjeHorizontal = Input.GetAxis("Horizontal");
        float kretanjeVertical = Input.GetAxis("Vertical");

        //postavljanje
        Vector3 kretanje = new Vector3(kretanjeHorizontal, 0.0f, kretanjeVertical);

        
        //dodavanje sile
        rb.AddForce (movement * speed);
    }

     void OnTriggerEnter(Collider other)
    {
        //provjera
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //objekt
            other.gameObject.SetActive(false);

            //nakon pov
            //povecava za 1
            zbroj += 1;
            SetCountText();
        }
    }

    void SetCountText ()
    {
        countText.text = "Rezultat: " + zbroj.ToString();
    }
}