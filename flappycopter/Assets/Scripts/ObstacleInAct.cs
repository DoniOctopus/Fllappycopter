using UnityEngine;
using System.Collections;

public class ObstacleInAct : MonoBehaviour {

		// inisialisasi variabel
    public Vector2 veloc = new Vector2(-4,0);


	void Start () {
		//memanggil komponen rigidbody3D ke gambar batu
        GetComponent<Rigidbody2D>().velocity = veloc;
        float range = 3; //jarak antar batu pertama dengan batu berikutnya 
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
