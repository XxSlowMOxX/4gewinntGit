using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int runde = 0;
    public static int[,] board = new int[7, 6];
    // Start is called before the first frame update
    void Start()
    {

    }

    public static void printboard()
    {
        for (int i = 0; i < 5; i++)
        {
            int[] outputti = new int[7];
            for (int c = 0; c < 6; c++)
            {
                outputti[c] = (board[c, i]);

            }
            string result = "";
            foreach (var item in outputti)
            {
                result += item.ToString() + ", ";
            }
            Debug.Log(result);
        }

        print("");
    }

    public static bool checkWin()
    {
        for (int row = 0; row < 5; row++)
        {
            for (int i = 0; i < 4; i++)
            {
                if (board[i, row] != 0)
                {
                    if (board[i, row] == board[i + 1, row])
                    {
                        if (board[i + 2, row] == board[i + 3, row])
                        {
                            if (board[i + 1, row] == board[i + 3, row])
                            {
                                return true;
                            }
                        }
                    }
                }
            }

        }


        for (int i = 0; i < 6; i++)
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[i, row] != 0)
                {

                    if (board[i, row] == board[i, row + 1])
                    {
                        if (board[i, row + 1] == board[i, row + 2])
                        {

                            if (board[i, row] == board[i, row + 3])
                            {
                                return true;
                            }
                        }
                    }
                }

            }
        }

        return false;
    }
    public static void gezippt(int collumn)
    {
        for (int i = 0; i < 5; i++)
        {
            if (board[collumn, i] == 0)
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
