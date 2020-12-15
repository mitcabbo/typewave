using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
  
  private static string[] wordList = { "sidewalk", "bird", "music", "star", "school", "fruit", "key", "fun", "blast", "need", "many", "hopeful", "armor", "sad", "fast", "legend", "music", "sun",
  "edit", "select", "accurate", "static", "dangerous", "wood", "empire", "special", "mom", "vehicle", "jar", "cap", "board", "flash", "ring", "telephone", "array", "signal", "schedule", "unusual",
  "delicate", "democracy", "root", "random", "continental", "yellow", "red", "blue", "evil", "pillow", "mirror", "monitor"};
  
  public static string GetRandomWord ()
  {
      int randomIndex = Random.Range(0, wordList.Length);
      string randomWord = wordList[randomIndex];

      return randomWord;
  }
}
