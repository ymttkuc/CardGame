using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardView : MonoBehaviour {

    //カードの1枚についての表示

    public string TAG = "Card View";
    
    public CardObj cardObj;
    public Vector2 size;    //範囲の大きさ（カードの大きさを2.5*3.5とする）

    public GameObject child_damageView;
    public GameObject damageNum;

    enum Layer {
        damageView,
        damageNum,
        size
    }

    //カードの向きの変更にかかる時間
    public int period;
    int frame;

    private void Awake() {
        
        damageNum = Number.CreatePrefab();
    }

    // Update is called once per frame
    void Update () {
        SpendUpdate();
        DamageUpdate();
	}

    //カードの向きの設定
    void SpendUpdate() {
        if (cardObj.card.isExtend) { if (--frame < 0) { frame = 0; } } else { if (++frame >= period) { frame = period; } }
        float angle = Utility.GetRatio(0, -90, (float)frame / period);

        cardObj.transform.eulerAngles = new Vector3(0, 0, angle);
    }

    void DamageUpdate() {
        if (cardObj.card.damage > 0) {
            child_damageView.SetActive(true);
            damageNum.GetComponent<Number>().num = cardObj.card.damage;
            damageNum.GetComponent<Number>().isDebuff = true;
        } else {
            child_damageView.SetActive(false);
        }
    }

    public void LayerSet(int _num, string _tag) {
        int num = _num * CardLayer.GetAllSize() + (int)CardLayer.Obj.size;
        for (Layer i = 0; i != Layer.size; ++i) {
            SpriteRenderer spriteRenderer;
            GameObject gameObject = null;
            switch (i) {
            case Layer.damageView: gameObject = child_damageView; break;
            case Layer.damageNum: gameObject = damageNum; break;
            default: break;
            }
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingLayerName = _tag;
            spriteRenderer.sortingOrder = num + (int)i;
        }
    }
    public void LayerSet(int _num) { LayerSet(_num, TAG); }

}
