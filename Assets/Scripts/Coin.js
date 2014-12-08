#pragma strict
//private var Coinj : GameObject;
private var hitCount : GUIText; 
var Counter : int = 0;

var CoinSound : AudioClip ;
//Coin = new GameObject ("David_Allaire-By_MobileEarth.ind");
	//Coin.AddComponent ("Rigidbody");
	//Coin.AddComponent ("BoxCollider");
	


function Start () {
    //Destroy(gameObject, 1); 
    
}

function Update () {

}

/*function OnControllerColliderHit(hit : ControllerColliderHit){
	Destroy(gameObject, 1);
	audio.PlayOneShot(CoinSound);
	
}*/
function OnCollisionEnter(col : Collision) 
{ 
	Debug.Log("yes! hit tray!");
  	Destroy(col.gameObject, 1);
  	audio.PlayOneShot(CoinSound);
  	//hitCount.text("bravo");
  	Counter++;
    guiText.text = "Point: "+Counter;

 /*if(col.gameObject.tag == "Coin" && col.gameObject.tag == "Player")
 {    Debug.Log("yes! hit tray!");
 
 		//col.gameObject.transform.position.y = 4;
 		Destroy(col.gameObject, 1);
 }*/
}
