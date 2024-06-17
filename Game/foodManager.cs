using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class foodManager : Singleton<foodManager>
{
    List<food> edibleFoodList;

    void Start()
    {
        edibleFoodList = new List<food>();

        edibleFoodList.Add(new food(4, "딸기타르트", Resources.Load<Sprite>("strawberry_tart")));
        edibleFoodList.Add(new food(2, "베이컨구이", Resources.Load<Sprite>("bacon")));
        edibleFoodList.Add(new food(4, "빵", Resources.Load<Sprite>("bread_roll")));
        edibleFoodList.Add(new food(2, "커피", Resources.Load<Sprite>("coffee")));
        edibleFoodList.Add(new food(6, "샌드위치", Resources.Load<Sprite>("sandwich")));
        edibleFoodList.Add(new food(4, "스프", Resources.Load<Sprite>("soup")));
        edibleFoodList.Add(new food(6, "초코칩쿠키", Resources.Load<Sprite>("cookie")));
        edibleFoodList.Add(new food(4, "계란후라이", Resources.Load<Sprite>("fried_egg")));
        edibleFoodList.Add(new food(6, "피자", Resources.Load<Sprite>("pizza")));
        edibleFoodList.Add(new food(4, "생선구이", Resources.Load<Sprite>("steamed_fish")));
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
