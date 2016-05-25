using UnityEngine;
using System.Collections;

public class Logic : Win {

	private MemoryCard[] cards = new MemoryCard[2];
	private int setsofcards;
	private int nroftries = 0;
	private AudioSource source;
	public AudioClip win;
	public AudioClip correctCombination;
	
	// Use this for initialization
	void Awake () {

		source = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void CheckCards(MemoryCard mc){
		if(cards[0] == null)
			cards[0] = mc;
		else{
			cards[1] = mc;
			nroftries++;
			
			if(cards[0].cardnumber == cards[1].cardnumber)
				CardsMatching();
			else
				CardsNotMatching();
			
			cards[0] = null;
			cards[1] = null;
		}
	}

	void CardsMatching(){
		cards[0].RemoveCard();
		cards[1].RemoveCard();
		source.PlayOneShot (correctCombination);
		setsofcards--;
		if(setsofcards == 0)
			GameEnd();
	}
	void CardsNotMatching(){
		cards[0].Hide();
		cards[1].Hide();
	}
	void GameEnd(){
		source.PlayOneShot (win);
		anim.Play ("Win");
		anim.SetBool ("end", true);

	}
	public void SetSetsOfCards(int i){
		setsofcards = i;
	}
}
