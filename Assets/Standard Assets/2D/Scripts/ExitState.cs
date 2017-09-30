using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitState : MonoBehaviour {
    void Update()
    {
        if (transform.position.x >= 10.77) Application.Quit();
    }
}
