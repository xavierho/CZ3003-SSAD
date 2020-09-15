using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    private int num;
    private int version;
    public Data(int num1)
    {
        num = num1;
        version = 1305200144;
    }

    public Data(int num1, int version1)
    {
        num = num1;
        version = version1;
    }

    public int GetNum()
    {
        return num;
    }

    public int GetVersion()
    {
        return version;
    }
}
