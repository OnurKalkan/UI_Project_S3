using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitching : MonoBehaviour
{
    public GameObject habitatPanel, skillsPanel;

    public void OpenHabitatPanel()
    {
        habitatPanel.SetActive(true);
        skillsPanel.SetActive(false);
    }
    public void OpenSkillsPanel()
    {
        habitatPanel.SetActive(false);
        skillsPanel.SetActive(true);
    }
}
