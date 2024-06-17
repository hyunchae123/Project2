using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class foodManager : Singleton<foodManager>
{
    List<food> edibleFoodList;

    void Start()
    {
        edibleFoodList = new List<food>();

        edibleFoodList.Add(new food(4, "����Ÿ��Ʈ", Resources.Load<Sprite>("strawberry_tart")));
        edibleFoodList.Add(new food(2, "����������", Resources.Load<Sprite>("bacon")));
        edibleFoodList.Add(new food(4, "��", Resources.Load<Sprite>("bread_roll")));
        edibleFoodList.Add(new food(2, "Ŀ��", Resources.Load<Sprite>("coffee")));
        edibleFoodList.Add(new food(6, "������ġ", Resources.Load<Sprite>("sandwich")));
        edibleFoodList.Add(new food(4, "����", Resources.Load<Sprite>("soup")));
        edibleFoodList.Add(new food(6, "����Ĩ��Ű", Resources.Load<Sprite>("cookie")));
        edibleFoodList.Add(new food(4, "����Ķ���", Resources.Load<Sprite>("fried_egg")));
        edibleFoodList.Add(new food(6, "����", Resources.Load<Sprite>("pizza")));
        edibleFoodList.Add(new food(4, "��������", Resources.Load<Sprite>("steamed_fish")));
    }

    public food FoodGacha()
    {
        List<food> items = edibleFoodList.ToList<food>();

        for (int i = 0; i < 200; i++)
        {
            int ran1 = Random.Range(0, items.Count);
            int ran2 = Random.Range(0, items.Count);

            food temp = items[ran1];
            items[ran1] = items[ran2];
            items[ran2] = temp;
        }

        food slectedItem = items[0];

        return items[0];
    }

}
