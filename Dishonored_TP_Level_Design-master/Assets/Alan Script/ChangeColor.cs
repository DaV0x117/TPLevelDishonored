using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] GameObject m_withColor;
    [SerializeField] GameObject m_withoutColor;

    bool m_colorisActive = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            m_colorisActive = !m_colorisActive;

            if (m_colorisActive)
            {
                m_withColor.SetActive(true);
                m_withoutColor.SetActive(false);
            }
            else
            {
                m_withColor.SetActive(false);
                m_withoutColor.SetActive(true);
            }
        }
    }

}