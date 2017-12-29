using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {

	// inisialisasi variabel
    public Vector2 jumpForce = new Vector2(0,300);

	
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
		// mengubah input arah menjadi input klik / tekan (jika di android) 
        float touchclicked = Input.GetAxis("Fire1");
        if (touchclicked == 1f)
        {
			// ketika di klik memberikan daya dorong keatas
            GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
            GetComponent<Rigidbody2D> ().AddForce(jumpForce);
        }
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

		// ketika helikopter jatuh jebawah 
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
		// ketika tag helikopter bertemu dengan tag "obstacle" maka mati
        if (coll.gameObject.tag == "Obstacle")
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("Menu");
    }

    
}
