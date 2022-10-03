using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello,World");

        int score = 150;
        Debug.Log(score);

        int a = 3;
        int b = 4;
        int c = a + b;
        Debug.Log(c);

        int money = 100;

        if (money <= 50)
        {
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            Debug.Log("武器を買う");
        }
        else
        {
            Debug.Log("ポーションを買う");
        }

        int num = 1;
        int var = (num == 1) ? -100 : 100;
        Debug.Log(var);

        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);


        int[] points = { 20, 50, 20, 60, 90, 20, 60, 20 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 50)
            {
                Debug.Log(points[i]);
            }
        }

        void Hello()
        {
            Debug.Log("Hello,UnityChan");
        }

        Hello();

        void Goodbye()
        {
            Debug.Log("Goodbye,UnityChan");
        }

        Goodbye();


        void HelloName(string name)
        {
            Debug.Log("Hello," + name);
        }

        HelloName("Unity");


        int Add(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }

        int num2 = Add(3, 6, 9);
        Debug.Log(num2);

        Boss lastboss = new Boss();

        lastboss.Atack();
        lastboss.Defence(3);



        Boss midboss = new Boss();

        midboss.Atack();
        midboss.Defence(90);





        //ここから課題

        int[] array = { 3, 5, 7, 11, 13};
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

public class Boss
{
    int hp;
    int mp=53;
    int power;

    public void Atack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }


    //ここから課題
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }
}
