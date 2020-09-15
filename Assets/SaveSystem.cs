using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveLevel(int num)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.xml";
        //string path = "/player.xml";
        FileStream stream = new FileStream(path, FileMode.Create);

        Data data = new Data(num);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Data LoadLevel()
    {
        string path = Application.persistentDataPath + "/player.xml";
        //string path = "/player.xml";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }
}
