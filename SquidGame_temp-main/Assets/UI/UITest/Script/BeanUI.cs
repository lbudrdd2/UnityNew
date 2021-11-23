using UnityEngine;
using UnityEngine.UI;

public class BeanUI : MonoBehaviour
{
    public Image[] beanList;
    public int currentBean;
    private int maxBean;

    public Sprite bean;
    public Sprite used;

    // Start
    private void Awake()
    {

        currentBean = maxBean;
        maxBean = beanList.Length;

        for (int i = 0; i < maxBean; i++)
            if (i < currentBean)
            {
                beanList[i].sprite = bean;
            }
    }



    public void SetBean(int val)
    {
        currentBean = val;
        currentBean = Mathf.Clamp(currentBean, 0, maxBean);


        for (int i = 0; i < maxBean; i++)
                beanList[i].sprite = used;



        for (int i = 0; i < maxBean; i++)
            if (i < currentBean)
            {
                beanList[i].sprite = bean;
            }
    }
}

