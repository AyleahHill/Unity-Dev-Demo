using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    
    //// Start is called before the first frame update
    //void Start() {
    //}

    // Update is called once per frame
    void FixedUpdate() { //FixedUpdate() rather than Update() because Unity likes that for physics movement
        rb.AddForce(0, 0, 1000 * Time.deltaTime); // *deltaTime because that is how much time it was from last frame drawn (helpful for working with computers with various framrates to make it consistent)

    }
}
