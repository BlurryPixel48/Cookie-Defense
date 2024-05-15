using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    


    
    // Start is called before the first frame update
    void Start() {
        target = LevelManager.main.path[0];
        
    }

    // Update is called once per frame
    void Update() {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f) {
            pathIndex++;

            if (pathIndex >= LevelManager.main.path.Length) {
                Destroy(gameObject);
                return;

            }
            
        }

    }
}
