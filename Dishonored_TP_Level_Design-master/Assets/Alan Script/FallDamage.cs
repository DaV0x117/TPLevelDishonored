using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public Transform player;
    public float startYPos;
    public float endYPos;
    public float damageThreshold = 2;
    public bool damageMe = false;
    public bool firstCall = true;

    private void Update()
    {
        if (!this.GetComponent<RigidbodyFirstPersonController>().Grounded)
        {
            if (gameObject.transform.position.y > startYPos)
            {
                firstCall = true;
            }

            if (firstCall)
            {
                startYPos = gameObject.transform.position.y;
                firstCall = false;
                damageMe = true;
            }
        }

        if (this.GetComponent<RigidbodyFirstPersonController>().Grounded)
        {
            endYPos = gameObject.transform.position.y;
            if (startYPos - endYPos > damageThreshold)
            {
                if (damageMe)
                {
                    player.GetComponent<Player_Health>().DamagePlayer((int)startYPos - (int)endYPos - (int)damageThreshold);
                    damageMe = false;
                    firstCall = true;
                }
            }
        }
    }
}
