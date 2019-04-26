using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gem : MonoBehaviour {
	public int ID;
	public int x;
	public int y;
	
	public int moveDown;

	public bool matched;
	public bool readyToMove;

	public static Transform select;
	public static Transform moveTo;

    private int score;
    public scoreText;


	// Use this for initialization
	void Start () {
        score = 0;
        setScoreText();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnMouseOver(){
		//transform.localScale = new Vector3(myScale.x+0.2f, myScale.y+0.2f,myScale.z+0.2f);
		if (Input.GetMouseButtonDown(0)){
			if(!select){
				select = transform;
				//transform.localScale = new Vector3(myScale.x+0.2f, myScale.y+0.2f,myScale.z+0.2f);
			}
			else if(select != transform && !moveTo)	{
				moveTo = transform;
			}
		}
	}

	public void DestroyBall()
	{
		//ScoreManager.score += scoreValue;
		Destroy (gameObject);
        score = score + 1;
	}

	public void MoveByY(){
		Vector3 correctPosition = new Vector3 (x,y,0);
		Vector3 newPosition = new Vector3 (correctPosition.x, correctPosition.y - moveDown, correctPosition.z);
		transform.position = Vector3.Lerp (correctPosition, newPosition, 1);


		//transform.position = new Vector3 (x, y - moveDown, 0);

	//	ScoreManager.score += scoreValue;
	}

    void setscoreText()
    {
        scoreText.text = "Score " + score.ToString();
    }


}
