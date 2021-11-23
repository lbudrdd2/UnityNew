using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    public Image[] heartList;
    public int hp;
    private int maxHp;

    public Sprite back, front;

    // Start
    private void Awake()
    {

        hp = maxHp;
        maxHp = heartList.Length;
       
        // maxHp
        for (int i = 0; i < maxHp; i++)
            if (i < hp)
            {
                heartList[i].sprite = front;
            }

    }

    public void Initialize()
    {
        hp = 5;
    }
    public int Hp { get; private set; }

    
    public void SetHp(int val)
    {
        // + hp when you restart the game
        hp = val;

        // - hp : when you die  ex SetHp(-1)

        // hp : 0 ~ maxHp
        hp = Mathf.Clamp(hp, 0, maxHp);

        // All back
        for (int i = 0; i < maxHp; i++)
            heartList[i].sprite = back;

        // draw current hp
        for (int i = 0; i < maxHp; i++)
            if (i < hp)
            {
                heartList[i].sprite = front;
            }
    }
}
