using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valrok.Saving.PlayerPrefs
{
    /// <summary>
    /// Sets playerprefs data and manages it
    /// </summary>
    public static class DataManager
    {
        public static void SetString(Keys key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key.ToString(), value);
        }

        public static void SetInt(Keys key, int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key.ToString(), value);
        }

        public static void SetBool(Keys key, bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key.ToString(), value == true ? 1 : 0);
        }

        public static string GetString(Keys key)
        {
           return UnityEngine.PlayerPrefs.GetString(key.ToString());
        }

        public static int GetInt(Keys key)
        {
            return UnityEngine.PlayerPrefs.GetInt(key.ToString());
        }

        public static bool GetBool(Keys key)
        {
            bool value = UnityEngine.PlayerPrefs.GetInt(key.ToString()) > 0 ? true : false;
            return value;
        }

        public static void Delete(Keys key)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key.ToString());
        }
    }

    public enum Keys
    {
        Score,
        TimePlayedInMin,
        TimesDied,
        AdsPlayed,
    }
}
