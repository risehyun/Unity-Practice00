[System.Serializable]
public class BaseEnemy
{
    public string name;

    public enum Type
    { 
        GRASS,
        FIRE,
        WATER,
        ELECTEIC
    }

    public enum Rarity
    { 
        COMMON,
        UNCOMMON,
        RARE,
        SUPERRARE
    }

    public Type EnemyType;
    public Rarity rarity;

    public float baseHp;
    public float curHp;

    public float baseMp;
    public float curMp;

    public float baseATK;
    public float curATK;

    public float baseDEF;
    public float curDEF;

}
