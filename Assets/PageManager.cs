using UnityEngine;

public class PageManager : MonoBehaviour
{
	public int pages;
	public Enemy enemy;

	void OnTriggerEnter(Collider other)
	{
		print("page collected!");
		Destroy(other.gameObject);

		pages++;

		if (pages == 1)
		{
			// ai wake up
			enemy.target = transform;
		}

		if (pages == 2)
		{
			// ai speed 2x
			enemy.speed *= 2;
		}

		// 3 more pages
		// enemy becomes stronger, sounds, second enemy
	}
}