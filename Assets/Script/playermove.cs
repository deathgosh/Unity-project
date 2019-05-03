    using UnityEngine;
    public class playermove : MonoBehaviour
    {
        public Rigidbody rb ;
        public float forwardForce = 2000f;
        public float sideforce = 500f;
        // Update is called once per frame
        void Update()
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("right"))
            {
             rb.AddForce(sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            }
            if (Input.GetKey("left"))
            {
                rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if(rb.position.y < -1)
            {
                FindObjectOfType<GameManager>().GameEnd();

            }
        }

    }
