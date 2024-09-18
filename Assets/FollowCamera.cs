using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // this things position (camera) should be the same as the cars position
    /**
    Κάνει την κάμερα ή κάποιο άλλο αντικείμενο να ακολουθεί ένα άλλο αντικείμενο (το οποίο καθορίζεται μέσω του thingToFollow)
    */
    //Δημιουργεί μια αναφορά σε ένα αντικείμενο του παιχνιδιού (GameObject) που η κάμερα ή άλλο αντικείμενο θα ακολουθεί
    [SerializeField] GameObject thingToFollow;

    /**
    Η μέθοδος void LateUpdate() στην Unity είναι παρόμοια με τη μέθοδο Update(), με τη διαφορά ότι εκτελείται μετά την Update(). Χρησιμοποιείται κυρίως όταν χρειάζεται να βεβαιωθείς ότι οι ενέργειες που εξαρτώνται από την ενημέρωση άλλων αντικειμένων έχουν ολοκληρωθεί.
    */
    void LateUpdate()
    {
        /**
        transform.position = thingToFollow.transform.position: Αυτό ορίζει τη θέση του αντικειμένου στο οποίο εφαρμόζεται το script (π.χ. κάμερα) να είναι ίση με τη θέση του αντικειμένου που ακολουθεί (thingToFollow).
        + new Vector3(0, 0, -10): Προσθέτει μια μετατόπιση στην κάμερα ή το αντικείμενο. Η μετατόπιση αυτή είναι κατά -10 μονάδες στον άξονα Z, κάτι που σημαίνει ότι το αντικείμενο που ακολουθεί είναι πιο μπροστά στον κόσμο του παιχνιδιού, και η κάμερα παραμένει λίγο πιο πίσω (ιδανικό για 2D παιχνίδια όπου η κάμερα πρέπει να είναι πίσω από το αντικείμενο στον άξονα Z για να το "βλέπει").
        */
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
