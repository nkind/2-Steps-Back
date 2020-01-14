using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeManDisappear : MonoBehaviour
{
   public void Doortalked()
    {
        PlayerPrefs.SetInt("ForeManDoor", 1);

    }
    public void Lobby3Talked()
    {
        PlayerPrefs.SetInt("ForeManLobby3", 1);
    }
    public void Lobby2Talked()
    {
        PlayerPrefs.SetInt("ForeManLobby2", 1);
    }
    public void Lobby1Talked()
    {
        PlayerPrefs.SetInt("ForeManLobby1", 1);
    }
    public void LobbyJanitor()
    {
        PlayerPrefs.SetInt("bioJanitor", 1);
    }

}
