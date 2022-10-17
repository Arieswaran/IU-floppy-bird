using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;
    [SerializeField]
    private SpriteRenderer coinSprite;
    [SerializeField]
    private Sprite[] coinImgs;
    private int rand;

    private void Start() {
        rand = Random.Range(0, coinImgs.Length);
        coinSprite.sprite = coinImgs[rand];
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        ScoreController.instance.AddScore(rand+1);
        coin.gameObject.SetActive(false);
    }
}
