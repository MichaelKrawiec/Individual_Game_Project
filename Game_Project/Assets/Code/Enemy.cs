using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 4f;

    public Node startingPosition;

    private GameObject Player;

    private Node currentNode, targetNode, previousNode;
    private Vector2 direction, nextDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
