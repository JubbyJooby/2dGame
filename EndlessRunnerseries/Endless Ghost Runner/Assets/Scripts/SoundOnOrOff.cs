using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnOrOff : MonoBehaviour
{
    public void SoundOff()
    {
        AudioListener.pause = true;
    }

    public void SoundOn()
    {
        AudioListener.pause = false;
    }
}
