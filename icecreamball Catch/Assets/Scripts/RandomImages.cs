using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomImages : MonoBehaviour
{
    public Image DrawImage;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;
    public Sprite Image10;
    public Sprite Image11;
    public Sprite Image12;
    public Sprite Image13;
    public Sprite Image14;
    public Sprite Image15;
    public Sprite Image16;
    public Sprite Image17;
    public Sprite Image18;
    public Sprite Image19;
    public Sprite Image20;

    public static int RandomInt;

    void Start()
    {
        ShowImage();
    }

    void Update()
    {
        
    }

    public int ShowImage()
    {
        RandomInt = Random.Range(0, 20);
        if (RandomInt == 1)
        {
            DrawImage.sprite = Image1;
            return RandomInt;
        }
        else if (RandomInt == 2)
        {
            DrawImage.sprite = Image2;
            return RandomInt;
        }
        else if (RandomInt == 3)
        {
            DrawImage.sprite = Image3;
            return RandomInt;
        }
        else if (RandomInt == 4)
        {
            DrawImage.sprite = Image4;
            return RandomInt;
        }
        else if (RandomInt == 5)
        {
            DrawImage.sprite = Image5;
            return RandomInt;
        }
        else if (RandomInt == 6)
        {
            DrawImage.sprite = Image6;
            return RandomInt;
        }
        else if (RandomInt == 7)
        {
            DrawImage.sprite = Image7;
            return RandomInt;
        }
        else if (RandomInt == 8)
        {
            DrawImage.sprite = Image8;
            return RandomInt;
        }
        else if (RandomInt == 9)
        {
            DrawImage.sprite = Image9;
            return RandomInt;
        }
        else if (RandomInt == 10)
        {
            DrawImage.sprite = Image10;
            return RandomInt;
        }
        else if (RandomInt == 11)
        {
            DrawImage.sprite = Image11;
            return RandomInt;
        }
        else if (RandomInt == 12)
        {
            DrawImage.sprite = Image12;
            return RandomInt;
        }
        else if (RandomInt == 13)
        {
            DrawImage.sprite = Image13;
            return RandomInt;
        }
        else if (RandomInt == 14)
        {
            DrawImage.sprite = Image14;
            return RandomInt;
        }
        else if (RandomInt == 15)
        {
            DrawImage.sprite = Image15;
            return RandomInt;
        }
        else if (RandomInt == 16)
        {
            DrawImage.sprite = Image16;
            return RandomInt;
        }
        else if (RandomInt == 17)
        {
            DrawImage.sprite = Image17;
            return RandomInt;
        }
        else if (RandomInt == 18)
        {
            DrawImage.sprite = Image18;
            return RandomInt;
        }
        else if (RandomInt == 19)
        {
            DrawImage.sprite = Image19;
            return RandomInt;
        }
        else if (RandomInt == 20)
        {
            DrawImage.sprite = Image20;
            return RandomInt;
        }
        else
        {
            return -1;
        }
        
    }

    /*
    public void CloseDraw()
    {
        DrawImage.sprite = null;
    }
    */
}
