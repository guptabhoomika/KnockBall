using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        float a = Mathf.Clamp(player.position.z, 0, Mathf.Infinity);
		scoreText.text = a.ToString("0");
        
	}
}
