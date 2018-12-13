using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public static class DataManager {														//This static class handles the whole games saving and loading of the high score

	public static PlayerData highScore = null;											//Player's high score information
	public static string path = "/juggleData.dat";										//Relative path of data file

	public static void Save(int balls, int score) {										//Save high score to file

		BinaryFormatter bf = new BinaryFormatter();										//Binary Formatters can serialize and deserialize objects to/from data files
		FileStream file = File.Create(Application.dataPath + path);						//Creates new file or overwrites existing one
		highScore = new PlayerData(balls, score);										//Creates object with data to store
		bf.Serialize(file, highScore);													//Serializes highScore object into file
		file.Close();																	//Closes file when done

	}

	public static bool Load() {															//Load existing highScore data. This function returns an error code that states whether the load was successful. True means success while false means fail

		if (File.Exists(Application.dataPath + path)) {									//Verifies that file actually exists before attempting to load
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.dataPath + path, FileMode.Open);	//Opens file
			highScore = (PlayerData)bf.Deserialize(file);								//Deserializes object from file, casts it to type PlayerData, and stores it in highScore
			file.Close();																//Closes file when done
			return true;
		}
		
		return false;
	}

}

[Serializable]
public class PlayerData {																//This class stores highScore data

	private int balls;																	//Highest ball count achieved
	public int Balls																	//Balls property. It is read-only
	{
		get {
			return balls;
		}
	}
	private int score;																	//Highest score achieved
	public int Score																	//Score property. It is read-only
	{
		get {
			return score;
		}
	}

	public PlayerData(int balls, int score) {											//PlayerData constructor

		this.balls = balls;
		this.score = score;

	}

}