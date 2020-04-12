using UnityEngine;

public class Enemy : MonoBehaviour
{ /// <summary>
   /// 怪物的血量
   /// </summary>
   [Header("血量"), Range(50, 500)]
    [Tooltip("怪物的血量")]
    public int hp  ;

    /// <summary>
   /// 怪物的魔力
   /// </summary>
   [Header("魔力"), Range(10, 100)]
    [Tooltip("怪物的魔力")]
    public int mp = 100;

    /// <summary>
    /// 怪物的移動速度
    /// </summary>
	[Header("怪物的移動速度"), Range(1, 50.5f)]
    public float ms = 50.5f;

    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
	[Range(20, 200)]
    public int ma = 50;

    /// <summary>
    /// 怪物的防禦力
    /// </summary>
	[Range(0, 100)]
    public int dp ;

    /// <summary>
    /// 武器的名稱
    /// </summary>
	[Header("裝備")]
    public string wp ;

    /// <summary>
    /// 裝備的名稱
    /// </summary>
	 public string wn = ("皮衣");

    /// <summary>
    /// 是否有帶鑰匙
    /// </summary>
    [Header("其他資料"), Tooltip("怪物是否有帶鑰匙")]
    public bool key = false;

    /// <summary>
    /// 是否掉落寶物
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]
    public bool tr = false;

}


