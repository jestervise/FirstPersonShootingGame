
using UnityEngine;

public class Gun : MonoBehaviour {
    public float distance=100f;
    public float damage = 10f;
    public Camera fpsCam;
    public GameObject muzzleFlash;

	
	// Update is called once per frame
	void Update () {
      
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot() {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, distance))
        {
            Instantiate(muzzleFlash, transform.forward, Quaternion.identity);
            Debug.Log(hit.transform.name);
            Destruction destructable=hit.transform.GetComponent<Destruction>();
            if (destructable != null) {
                destructable.TakeDamage(damage);
            }
        }
    }
}
