using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1, 1);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /**
    Είναι μια ειδική συνάρτηση που εκτελείται αυτόματα όταν συμβεί μια σύγκρουση 2D μεταξύ του αντικειμένου στο οποίο είναι συνημμένο αυτό το script και κάποιου άλλου αντικειμένου. Αποτελεί μέρος του συστήματος φυσικής της Unity για 2D παιχνίδια
    */
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    /**
    Ενεργοποιείται όταν το αντικείμενο στο οποίο είναι συνημμένο το script εισέρχεται σε μια περιοχή trigger άλλου αντικειμένου στο 2D περιβάλλον. Αυτή η μέθοδος είναι μέρος της 2D φυσικής και χρησιμοποιείται όταν θες να ανιχνεύσεις την είσοδο ενός αντικειμένου σε έναν καθορισμένο χώρο (όπως μια ζώνη, περιοχή, ή όριο) χωρίς να χρειάζεται πραγματική σύγκρουση
    */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {

            Debug.Log("package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);

        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivery to customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
