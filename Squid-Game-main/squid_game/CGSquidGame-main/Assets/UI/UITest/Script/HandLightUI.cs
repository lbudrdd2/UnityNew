using UnityEngine;
using UnityEngine.UI;

public class HandLightUI : MonoBehaviour
{
    public Image[] handlightList;
    public int num;
    private int maxNum;

    public Sprite handlight;

    // Start
    private void Awake()
    {

        num = maxNum;
        maxNum = handlightList.Length;

        // maxHp
        for (int i = 0; i < maxNum; i++)
            if (i < num)
            {
                handlightList[i].sprite = handlight;
            }
    }



    public void SetHandlight(int val)
    {
        // + hp when you restart the game
        num += val;

        // - hp : when you die  ex SetHp(-1)

        // hp : 0 ~ maxHp
        num = Mathf.Clamp(num, 0, maxNum);

        // draw current hp
        for (int i = 0; i < maxNum; i++)
            if (i < num)
            {
                handlightList[i].sprite = handlight;
            }
    }
}
