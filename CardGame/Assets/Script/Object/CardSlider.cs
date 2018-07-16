using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlider : MonoBehaviour {

    public string TAG;  //タグの名前
    public int OBJ_ID;  //オブジェクトの描画順

    //自由な移動ができるかどうか
    //これのtrue,falseで仕様が変わる
    bool isFreeMove;
    
    //カード群
        
    public List<CardView> cards;
    
    public float length;    //表示範囲の長さ（カード大きさを2.5*3.5とする）
    public float moveEnd;   //カードの移動限界（isFreeMove == true）

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
