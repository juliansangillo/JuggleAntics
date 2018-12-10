using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public static class DataManager {

	public static PlayerData highScore;
	public static string path = "/juggleData.dat";

	public static void Save(int balls, int score) {

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.dataPath + path);
		highScore = new PlayerData(balls, score);
		bf.Serialize(file, highScore);
		file.Close();

	}

	public static void Load() {

		if (File.Exists(Application.dataPath + path)) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.dataPath + path, FileMode.Open);
			highScore = (PlayerData)bf.Deserialize(file);
			file.Close();
		}

	}

}

[Serializable]
public class PlayerData {

	private int balls;
	public int Balls
	{
		get {
			return balls;
		}
	}
	private int score;
	public int Score
	{
		get {
			return score;
		}
	}

	public PlayerData(int balls, int score) {

		this.balls = balls;
		this.score = score;

	}

}