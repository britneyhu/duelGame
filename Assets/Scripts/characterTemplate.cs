using UnityEngine;

[CreateAssetMenu(fileName = "characterTemplate", menuName = "Scriptable Objects/characterTemplate")]
public class characterTemplate : ScriptableObject
{
    public int index;
    public string charName;
    public float maxHealth;
    public float maxSpeed;
    public float maxJump;

    public string ability1;
    public string ability2;
    public string ult;

    public float currentHealth;
}
