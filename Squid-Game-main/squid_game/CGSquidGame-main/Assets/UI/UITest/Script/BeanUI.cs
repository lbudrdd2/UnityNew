using UnityEngine;
using UnityEngine.UI;

public class BeanUI : MonoBehaviour
{
    public Image[] beanList;
    public int currentBean;
    private int maxBean;

    public Sprite bean;

    // Start
    private void Awake()
    {

        currentBean = maxBean;
        maxBean = beanList.Length;

        // maxHp
        for (int i = 0; i < maxBean; i++)
            if (i < currentBean)
            {
                beanList[i].sprite = bean;
            }
    }

    public void Initialize()
    {
        currentBean = 3;
    }
    public int Bean { get; private set; }

    public void SetBean(int val)
    {
        // + hp when you restart the game
        currentBean += val;

        // - hp : when you die  ex SetHp(-1)

        // hp : 0 ~ maxHp
        currentBean = Mathf.Clamp(currentBean, 0, maxBean);

        // draw current hp
        for (int i = 0; i < maxBean; i++)
            if (i < currentBean)
            {
                beanList[i].sprite = bean;
            }
    }
}
