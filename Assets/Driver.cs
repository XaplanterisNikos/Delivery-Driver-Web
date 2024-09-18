using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // SerializeField είναι ένα χαρακτηριστικό (attribute) στην Unity που επιτρέπει σε ιδιωτικές μεταβλητές (private fields) να εμφανίζονται και να είναι επεξεργάσιμες στο Inspector της Unity, χωρίς να αλλάζει η ορατότητά τους στον κώδικα
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 12f;
    [SerializeField] float slowSpeed = 8f;
    [SerializeField] float boostSpeed = 30f;




    void Update()
    {
        /** 
        Tο Input.GetAxis("Horizontal") χρησιμοποιείται για να ελέγξει αν ο παίκτης κινείται δεξιά, αριστερά, ή αν παραμένει ακίνητος στον οριζόντιο άξονα ,επιστρέφει μια αριθμητική τιμή από -1 έως 1
        Το Time.deltaTime εξασφαλίζει ότι η κίνηση είναι σταθερή ανεξάρτητα από το ρυθμό των καρέ.
        */
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;

        /** χρησιμοποιείται για να πάρει την είσοδο του χρήστη που σχετίζεται με την κίνηση στον κάθετο άξονα (πάνω-κάτω),επιστρέφει μια αριθμητική τιμή από -1 έως 1
        Το Time.deltaTime εξασφαλίζει ότι η κίνηση είναι σταθερή ανεξάρτητα από το ρυθμό των καρέ.
        */
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // περιστρέφει το αντικείμενο γύρω από τους άξονες x, y, και z
        transform.Rotate(0, 0, -steerAmount);

        // μετακινεί το αντικείμενο κατά ένα συγκεκριμένο διάστημα στις συντεταγμένες x, y, και z.
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            //Debug.Log("Boost !!!!!!");
            moveSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        moveSpeed =slowSpeed;
    }

}
