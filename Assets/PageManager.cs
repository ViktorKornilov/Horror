using UnityEngine;

public class PageManager : MonoBehaviour
{
    public int pages;
    public Enemy enemy;

    void OnTriggerEnter(Collider other)
    {
        print( "You found a page!" );
        Destroy( other.gameObject );
        pages++;

        if (pages == 1)
        {
            // enemy wake up
            enemy.target = transform;
        }

        if (pages == 2)
        {
            // speed up enemy 2X
            enemy.speed *= 2;
        }

        if (pages == 3)
        {

        }

        if (pages == 4)
        {

        }

    }
}