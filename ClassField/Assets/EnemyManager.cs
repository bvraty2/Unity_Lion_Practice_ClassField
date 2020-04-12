using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [Header("怪物一號")]
    public Enemy enemy1;

    [Header("怪物二號")]
    public Enemy enemy2;

    private void Start()
    {
        print("怪物一號的魔力");
        print("怪物一號的mp數是" + enemy1.mp);
        
        print("怪物二號的裝備名稱");
        print("怪物二號的裝備名稱" + enemy2.wn);

        enemy1.hp= 100;
        enemy2.hp = 300;
        enemy1.dp = 50;
        enemy1.wn = "木棍";
        enemy2.wn = "短刀";
        enemy1.key = true;
        enemy2.tr = true;

    }


}
