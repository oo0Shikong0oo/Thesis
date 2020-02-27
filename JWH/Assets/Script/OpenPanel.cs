using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update

        public void PanelOpener()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
    
}
