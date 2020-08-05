using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int runde = 0;
    public static int[,] board = new int[7,6];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void gezippt(int collumn)
    {
        for (int i = 0; i < 5; i++)
        {
            if(board[collumn, i]== 0)
            {
                board[collumn, i] = runde % 2 + 1;
                break;
            }
        }
        
       
        runde++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
