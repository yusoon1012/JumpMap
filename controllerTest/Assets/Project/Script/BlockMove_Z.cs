    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class BlockMove_Z : MonoBehaviour
    {
        Transform boxTransform;
        float initializePos;
        float movePosition;
        float moveSpeed = 3f;
        float maxMove = 0f;

        Rigidbody boxRigid; 
        private bool moveUp = default;
        private bool moveDown = default;
        // Start is called before the first frame update
        void Start()
        {
            boxRigid = GetComponent<Rigidbody>();

        }

        // Update is called once per frame
        void Update()
        {
            if(transform.position.y<=2)
            {
                moveUp = true;
                moveDown = false;
            }
            else if(transform.position.y >= 8)
            {
                moveUp = false;
                moveDown = true;
            }
            if(moveUp)
            {
            Vector3 moveBlock = new Vector3(0f, moveSpeed, 0f);

            boxRigid.velocity = moveBlock;
            }
        if (moveDown)
        {
            Vector3 moveBlock = new Vector3(0f, -moveSpeed, 0f);

            boxRigid.velocity = moveBlock;
        }
    }
    }
