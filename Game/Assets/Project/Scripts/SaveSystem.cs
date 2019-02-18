using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    public static void SavePlayer (Stats stats)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.savedata";
        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(stats);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static playerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.savedata";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerData data = formatter.Deserialize(stream) as playerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
