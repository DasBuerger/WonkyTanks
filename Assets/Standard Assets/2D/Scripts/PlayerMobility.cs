using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

    public float speed;
    private void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;
        float input = Input.GetAxis("Vertical");
        gameObject.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed * input);
    }
}
