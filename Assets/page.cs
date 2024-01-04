using UnityEngine;

public class page : MonoBehaviour
{
    public int pages;
    public Enemy enemy;
    public AudioSource source;

    void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        pages++;

        if (pages == 1)
        {
            enemy.target = transform;
        }
        if (pages == 2)
        {
            enemy.speed *= 2;
        }
        if (pages == 3)
        {
            enemy.viewDistance *= 2;
            source.Play();
        }
        if (pages == 4)
        {
            enemy.speed *= 2;
            source.Play();
        }
        if (pages == 5)
        {
            enemy.speed *= 2;
            enemy.viewDistance *= 100;
            source.Play();
        }
    }
}
