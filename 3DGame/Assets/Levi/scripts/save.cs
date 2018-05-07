using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class save : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
    void Start() {
        Load();
		Scene currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("Save"))
        {
            Save();
           // Debug.Log("saved");
        }
    }
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/" + gameObject.name + SceneManager.GetActiveScene().name + "Arcade.dat");
        Save info = new Save();
		//Save myData = new Save();
		if (sceneName == ("Game")) 
		{
        	info.x = transform.position.x;
        	info.y = transform.position.y;
        	info.z = transform.position.z;
		}
		info.playerProgress = PlayerPrefs.GetInt ("Progress");
        bf.Serialize(file, info);
        file.Close();
    }
    public void Load()
    {
		if (File.Exists(Application.persistentDataPath + "/" + gameObject.name + SceneManager.GetActiveScene().name + "Arcade.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/" + gameObject.name +"Arcade.dat", FileMode.Open);
            Save info = (Save)bf.Deserialize(file);
			if (sceneName == "Game") 
			{
				transform.position = new Vector3 (info.x, info.y, info.z);
				PlayerPrefs.SetInt ("Progress", info.playerProgress);
			}
			file.Close();
        }
    }

}

[Serializable] 
public class Save
{
	public float x;
    public float y;
    public float z;
		
	public int playerProgress;
}

