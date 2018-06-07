using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class TrackerManager : MonoBehaviour {

    public static void PlayerDied(int level) {
        Analytics.CustomEvent("Öut of Food and died on level"+ level);
    }

    public static void FoodPickedUp(string item) {
        Analytics.CustomEvent("Food picked up: "+ item);

    }

    public static void DamagedWall() {
        Analytics.CustomEvent("Attack the Wall");

    }

    public static void ClearedLevel(int level, string item, int amount, string timeString, int time) {

        Analytics.CustomEvent("Cleared level " + level + "with ", new Dictionary<string, object> { { item, amount }, {timeString, time } });

    }

    public static void GotHit() {
        Analytics.CustomEvent("Got Hit");

    }

    public static void ItemPickUp(string item) {
        Analytics.CustomEvent("Picked up: " + item);
    }


}
