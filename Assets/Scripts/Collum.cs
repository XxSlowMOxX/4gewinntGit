using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collum : MonoBehaviour
{
    public List<GameObject> stones = new List<GameObject>();


    [SerializeField]
    private GameObject stein;

    public int columnn;
    
    
    // Start is called before the first frame update
    void Start()
    {
           
    }

    public void click()
    {
       if (stones.Count == 6)
        {
            return;
        } 
       GameObject lokal = Instantiate(stein);
       lokal.transform.SetParent(this.gameObject.transform);
       lokal.transform.localPosition.Set(0 + 100 * stones.Count,0, 0);
       lokal.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,stones.Count*100 -this.GetComponent<RectTransform>().rect.height/2 + 50);

        if (Game.runde % 2 == 0)
        {
            lokal.GetComponent<Image>().color = Color.blue;
            
        }
        stones.Add(lokal);
        Game.gezippt(columnn);
        Game.printboard();
        print(Game.checkWin());

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            click();
        }

    }
}
