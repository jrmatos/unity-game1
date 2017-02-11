using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlaySound : ConditionBasedBehavior {

    public AudioSource sound;
    
    public override void OnConditionSatisfied () {
        sound.Play();
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(PlaySound))]
public class PlaySoundEditor : ConditionBasedEditor {

}
#endif
