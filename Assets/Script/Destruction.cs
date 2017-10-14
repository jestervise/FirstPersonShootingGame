using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {
    public GameObject crackedVersion;
    private void OnMouseDown()
    {
        Instantiate(crackedVersion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
