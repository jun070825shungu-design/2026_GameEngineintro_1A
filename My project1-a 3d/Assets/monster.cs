using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class monster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i);
        //}

        //int i = 0;
        //while(i < 10)
        //{
        //    Debug.Log("*"); 
        //    i++;  
        //}

        //int[] testArray = new int[10];

        // [10] [] [] [] [] [] [] [] [] []
        //

        //testArray[0] = 10;
        //testArray[1] = 11;
        //testArray[2] = 12;
        //testArray[3] = 13;

        //for(int i = 0; 1 < 10; i ++)
        //{
        //    testArray[i] = 10 + i;
        //    Debug.Log(testArray[i]);
        //}

        List<int> testList = new List<int>(); // { 0,1,2,3,4,5 };


        //for(int i = 0; i < 10; i++)
        //{
        //    testList.Add(i);
        //}
        //Debug.Log(testList[4]);

        //testList[0] = 15;
        Human man2 = new Human();
        string Human = "맨맨";
        List<Human> humans = new List<Human>();

        humans.Add(man2);

        for(int i = 0; i < humans.Count ; i++)
        {

        }



    }


    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * 0.03f;
        //transform.Translate(Vector3.right * 0.03f);



        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.03f);
        }   
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 0.03f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.03f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.03f);
        }

        
        
    }

    //public void invite(Human newuser)
    //{
    //    humans.Add(newuser); 
    //}
    //public void mention()
    //{
    //    for (int i = 0; i < humans.Count; i++) ;
    //}
}
