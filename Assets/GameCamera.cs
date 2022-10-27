using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    //This is Main Camera in the Scene
    Camera m_MainCamera;
   
    GameBoard gameBoard;
    int turn;

    // Start is called before the first frame update
    void Start()
    {
        m_MainCamera = Camera.main;        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("2"))
        {
            setTurn2();
            
        }
        else if (Input.GetKey("1"))
        {
            setTurn();
        }


        //m_MainCamera.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
        if (turn == 2)
        {       
            m_MainCamera.transform.position = Vector3.MoveTowards(transform.position, new Vector3(2.91000009f, 9.27000046f, 6.8f), 10f* Time.deltaTime);
            //m_MainCamera.transform.RotateAround(new Vector3(2.90120029f, 0.5f, -6.08087635f), new Vector3(0f, 0.1f, 0f), 45f * Time.deltaTime);
            m_MainCamera.transform.LookAt(new Vector3(2.90120029f, 0.5f, -6.08087635f));
        }

        if (turn == 1)
        {
            m_MainCamera.transform.position = Vector3.MoveTowards(transform.position, new Vector3(2.91000009f, 9.27000046f, -19f), 10f * Time.deltaTime);
            m_MainCamera.transform.LookAt(new Vector3(2.90120029f, 0.5f, -6.08087635f));
        }


        if (m_MainCamera.transform.position == new Vector3(2.91000009f, 9.27000046f, 6.8f))
        {
            m_MainCamera.transform.LookAt(new Vector3(2.90120029f, 0.5f, -6.08087635f));
        }
    }

  
    private int getTurn()
    {
        return turn;
    }

    private void setTurn()
    {
        this.turn= 1;
    }
    private void setTurn2()
    {
        this.turn = 2;
    }

}
