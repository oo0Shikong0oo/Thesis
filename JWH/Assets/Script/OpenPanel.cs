using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Panel;
    public static bool GameIsPaused = false;
    // Start is called before the first frame update

        public void PanelOpener()
    {
        Debug.Log("PanelOpening");
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        
    }

        void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
        void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
