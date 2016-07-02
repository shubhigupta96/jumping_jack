using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
    
   // public scoremanager ScoreManager;
   // private int val=100;
    // Use this for initialization
	public AudioClip x;
	public AudioSource y;
	private float vollowrange = .5f;
	private float volhighrange = 1.0f;


	void Start () {
		y = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
			y.PlayOneShot(x, 1F);
            //ScoreManager.AddPoints(val);
            Destroy(gameObject);
        }
    }

}
