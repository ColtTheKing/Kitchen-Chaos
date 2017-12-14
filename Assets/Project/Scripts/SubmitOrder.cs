﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitOrder : MonoBehaviour
{
    public TicketGen board;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        FoodComponent foodComp = collision.gameObject.GetComponent<FoodComponent>();
        if (foodComp != null)
        {
            Destroy(collision.gameObject);
            board.checkOrders(foodComp.food);
        }
    }
}
