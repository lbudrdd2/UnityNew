using UnityEngine;
using UnityEngine.UI;

public class HandLightUI : MonoBehaviour
{
    public Image[] handlightList;
    public int num;
    private int maxNum;

    public Sprite handlight;
    public Sprite used;
    
    private void Awake()
    {

        num = maxNum;
        maxNum = handlightList.Length;

        for (int i = 0; i < maxNum; i++)
            if (i < num)
            {
                handlightList[i].sprite = handlight;
            }
    }

    public void SetHandlight(int val)
    {
        num = val;

        num = Mathf.Clamp(num, 0, maxNum);

        for (int i = 0; i < maxNum; i++)
            handlightList[i].sprite = used;


        for (int i = 0; i < maxNum; i++)
            if (i < num)
            {
                handlightList[i].sprite = handlight;
            }
    }
}
