using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	private GameObject scoreText;

	private int score = 0;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		this.scoreText = GameObject.Find ("scoreText");

			
	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}
	void OnCollisionEnter(Collision other) {
		Debug.Log (other.gameObject.tag);

		if (other.gameObject.tag == "SmallStarTag") {
			score += 50;
			Debug.Log (score);
		}
			else if(other.gameObject.tag == "LargeStarTag"){
			score += 30;
				Debug.Log(score);
		}else if(other.gameObject.tag =="SmallCloudTag"){
			score += 50;
				Debug.Log(score);
		}else if (other.gameObject.tag =="LargeCloudTag"){
			score += 30;
			Debug.Log(score);
		}

		this.scoreText.GetComponent<Text> ().text = "score"+ this.score;
		
	}

}


