﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class LetterUI : MonoBehaviour
{
    public Transform A4, A5, A6, B4, B5, B6, C4, C5, C6, D4, D5, D6, E4, E5, E6, F4, F5, F6, G4, G5, G6, H4, H5, H6;
    public Transform A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z;
    public List<Transform> Col1 = new List<Transform>();
    public List<Transform> Col2 = new List<Transform>();
    public List<Transform> Col3 = new List<Transform>();
    public List<Transform> Col4 = new List<Transform>();
    public List<Transform> Col5 = new List<Transform>();
    public List<Transform> Col6 = new List<Transform>();
    public List<Transform> Col7 = new List<Transform>();
    public List<Transform> Col8 = new List<Transform>();
    public List<List<Transform>> Cols = new List<List<Transform>>();
    public List<Transform> Row1 = new List<Transform>();
    public List<Transform> Row2 = new List<Transform>();
    public List<Transform> Row3 = new List<Transform>();
    public List<List<Transform>> Rows = new List<List<Transform>>();
    public static List<DictionaryLookup> dictionaryLookupsList = new List<DictionaryLookup>();

    public static List<string> currentWords = new List<string>();
    public GameObject stage;

    string word;
    char[] board;



    void Start()
    {
        Col1.Add(A4);
        Col1.Add(A5);
        Col1.Add(A6);
        Col2.Add(B4);
        Col2.Add(B5);
        Col2.Add(B6);
        Col3.Add(C4);
        Col3.Add(C5);
        Col3.Add(C6);
        Col4.Add(D4);
        Col4.Add(D5);
        Col4.Add(D6);
        Col5.Add(E4);
        Col5.Add(E5);
        Col5.Add(E6);
        Col6.Add(F4);
        Col6.Add(F5);
        Col6.Add(F6);
        Col7.Add(G4);
        Col7.Add(G5);
        Col7.Add(G6);
        Col8.Add(H4);
        Col8.Add(H5);
        Col8.Add(H6);

        Cols.Add(Col1);
        Cols.Add(Col2);
        Cols.Add(Col3);
        Cols.Add(Col4);
        Cols.Add(Col5);
        Cols.Add(Col6);
        Cols.Add(Col7);
        Cols.Add(Col8);

        Row1.Add(A4);
        Row1.Add(B4);
        Row1.Add(C4);
        Row1.Add(D4);
        Row1.Add(E4);
        Row1.Add(F4);
        Row1.Add(G4);
        Row1.Add(H4);

        Row2.Add(A5);
        Row2.Add(B5);
        Row2.Add(C5);
        Row2.Add(D5);
        Row2.Add(E5);
        Row2.Add(F5);
        Row2.Add(G5);
        Row2.Add(H5);

        Row3.Add(A6);
        Row3.Add(B6);
        Row3.Add(C6);
        Row3.Add(D6);
        Row3.Add(E6);
        Row3.Add(F6);
        Row3.Add(G6);
        Row3.Add(H6);

        Rows.Add(Row1);
        Rows.Add(Row2);
        Rows.Add(Row3);
    }

    // letter buttons ----------------------------

    // optimise to a loop
    public void pressAButton()
    {
        GameObject aBlock = Instantiate(Resources.Load("Prefabs/Letters/a")) as GameObject;
        //aBlock.transform.SetParent(A4);
        setParent1(aBlock);
    }
    public void pressBButton()
    {
        GameObject bBlock = Instantiate(Resources.Load("Prefabs/Letters/b")) as GameObject;
        setParent1(bBlock);
    }
    public void pressCButton()
    {
        GameObject cBlock = Instantiate(Resources.Load("Prefabs/Letters/c")) as GameObject;
        setParent1(cBlock);
    }
    public void pressDButton()
    {
        GameObject dBlock = Instantiate(Resources.Load("Prefabs/Letters/d")) as GameObject;
        setParent1(dBlock);
    }
    public void pressEButton()
    {
        GameObject eBlock = Instantiate(Resources.Load("Prefabs/Letters/e")) as GameObject;
        setParent1(eBlock);
    }
    public void pressFButton()
    {
        GameObject fBlock = Instantiate(Resources.Load("Prefabs/Letters/f")) as GameObject;
        setParent1(fBlock);
    }
    public void pressGButton()
    {
        GameObject gBlock = Instantiate(Resources.Load("Prefabs/Letters/g")) as GameObject;
        setParent1(gBlock);
    }
    public void pressHButton()
    {
        GameObject hBlock = Instantiate(Resources.Load("Prefabs/Letters/h")) as GameObject;
        setParent1(hBlock);
    }
    public void pressIButton()
    {
        GameObject iBlock = Instantiate(Resources.Load("Prefabs/Letters/i")) as GameObject;
        setParent1(iBlock);
    }
    public void pressJButton()
    {
        GameObject jBlock = Instantiate(Resources.Load("Prefabs/Letters/j")) as GameObject;
        setParent1(jBlock);
    }
    public void pressKButton()
    {
        GameObject kBlock = Instantiate(Resources.Load("Prefabs/Letters/k")) as GameObject;
        setParent1(kBlock);
    }
    public void pressLButton()
    {
        GameObject lBlock = Instantiate(Resources.Load("Prefabs/Letters/l")) as GameObject;
        setParent1(lBlock);
    }
    public void pressMButton()
    {
        GameObject mBlock = Instantiate(Resources.Load("Prefabs/Letters/m")) as GameObject;
        setParent1(mBlock);
    }
    public void pressNButton()
    {
        GameObject nBlock = Instantiate(Resources.Load("Prefabs/Letters/n")) as GameObject;
        setParent1(nBlock);
    }
    public void pressOButton()
    {
        GameObject oBlock = Instantiate(Resources.Load("Prefabs/Letters/o")) as GameObject;
        setParent1(oBlock);
    }
    public void pressPButton()
    {
        GameObject pBlock = Instantiate(Resources.Load("Prefabs/Letters/p")) as GameObject;
        setParent1(pBlock);
    }
    public void pressQButton()
    {
        GameObject qBlock = Instantiate(Resources.Load("Prefabs/Letters/q")) as GameObject;
        setParent1(qBlock);
    }
    public void pressRButton()
    {
        GameObject rBlock = Instantiate(Resources.Load("Prefabs/Letters/r")) as GameObject;
        setParent1(rBlock);
    }
    public void pressSButton()
    {
        GameObject sBlock = Instantiate(Resources.Load("Prefabs/Letters/s")) as GameObject;
        setParent1(sBlock);
    }
    public void pressTButton()
    {
        GameObject tBlock = Instantiate(Resources.Load("Prefabs/Letters/t")) as GameObject;
        setParent1(tBlock);
    }
    public void pressUButton()
    {
        GameObject uBlock = Instantiate(Resources.Load("Prefabs/Letters/u")) as GameObject;
        setParent1(uBlock);
    }
    public void pressVButton()
    {
        GameObject vBlock = Instantiate(Resources.Load("Prefabs/Letters/v")) as GameObject;
        setParent1(vBlock);
    }
    public void pressWButton()
    {
        GameObject wBlock = Instantiate(Resources.Load("Prefabs/Letters/w")) as GameObject;
        setParent1(wBlock);
    }
    public void pressXButton()
    {
        GameObject xBlock = Instantiate(Resources.Load("Prefabs/Letters/x")) as GameObject;
        setParent1(xBlock);
    }
    public void pressYButton()
    {
        GameObject yBlock = Instantiate(Resources.Load("Prefabs/Letters/y")) as GameObject;
        setParent1(yBlock);
    }
    public void pressZButton()
    {
        GameObject zBlock = Instantiate(Resources.Load("Prefabs/Letters/z")) as GameObject;
        setParent1(zBlock);
    }


    // for 3 rows
    private void setParent1(GameObject block)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int h = 0; h < 8; h++)
            {
                if (Rows[i][h].childCount == 0)
                {
                    block.transform.SetParent(Rows[i][h], false);
                    break;
                }
                else
                {
                    continue;
                }
            }
            break;
        }

        // update
        GameObject gameControl = GameObject.Find("GameControl");
        GameControl gameControlScript = gameControl.GetComponent<GameControl>();
        gameControlScript.UpdateStage();
    }


    public void ClearBlocks()
    {
        for (int i = 0; i < Row1.Count; i++)
        {
            if (Row1[i].childCount > 0)
            {
                Destroy(Row1[i].transform.GetChild(0).gameObject);
            }
        }
        for (int i = 0; i < Row2.Count; i++)
        {
            if (Row2[i].childCount > 0)
            {
                Destroy(Row2[i].transform.GetChild(0).gameObject);
            }
        }
        for (int i = 0; i < Row3.Count; i++)
        {
            if (Row3[i].childCount > 0)
            {
                Destroy(Row3[i].transform.GetChild(0).gameObject);
            }
        }

        var fairy = GameObject.Find("Fairy");
        Fairy fairyScript = fairy.GetComponent<Fairy>();

        var subject = GameObject.Find("Subject");
        Subject subjectScript = subject.GetComponent<Subject>();

        // reset Fairy animation
        fairyScript.NoAnimation();

        // reset subject animation
        subjectScript.NoAnimation();
    }
}
