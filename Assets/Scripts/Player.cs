using UnityEngine;

public class Player : MonoBehaviour
{
	//+n text
	[SerializeField] GameObject coinNumPrefab;

	CoinsManager coinsManager;

	void Start ()
	{
		//find the CoinsManager
		coinsManager = FindObjectOfType<CoinsManager> ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		//check if player collides with a coin
		if (other.CompareTag ("coin")) {
			//Add coins 7
			coinsManager.AddCoins (other.transform.position, 7);

			Destroy (other.gameObject);

			//Show (+7) number
			Destroy (Instantiate (coinNumPrefab, other.transform.position, Quaternion.identity), 1f);
		}
	}
}
