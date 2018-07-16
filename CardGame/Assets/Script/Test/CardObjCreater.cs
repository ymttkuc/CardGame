using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObjCreater : MonoBehaviour {

    List<Card> cards;
    GameObject orig_cardView;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            var card = new Card(0, 0, 0, 0, GameScript.Zone.hand, null);
            var obj = CardObj.CreatePrefab();
            obj.transform.position
                = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(1.0f, 3.0f));
            obj.GetComponent<CardObj>().
            var view = Instantiate(orig_cardView);
            
        }
	}
}
