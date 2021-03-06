using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LS
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;

        private void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            inputHandler.isInteracting = anim.GetBool("isInteracting");
            inputHandler.rollFlag = false;
            inputHandler.sprintFlag = false;
        }
    }
}
