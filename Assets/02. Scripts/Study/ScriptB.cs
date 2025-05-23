using ProgrammerA;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public ScriptA scriptA;

    void Start()
    {
        //scriptA.aValue1 = 10;
        scriptA.aValue2 = 20;
        //scriptA.aValue3 = 30;
        //scriptA.aValue4 = 40;
        //scriptA.aValue5 = 50;
    }
}
