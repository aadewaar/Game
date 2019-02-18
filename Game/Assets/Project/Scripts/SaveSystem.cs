using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityStandardAssets.Characters.FirstPerson;

public static class SaveSystem {

    public static void SavePlayer (FirstPersonController FirstPersonController)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.savedata";
        FileStream stream = new FileStream(path, FileMode.Create);

        Save save = new Save(FirstPersonController);

        formatter.Serialize(stream, save);
        stream.Close();
    }

    public static Save LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.savedata";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Save save = formatter.Deserialize(stream) as Save;
            stream.Close();

            return save;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
