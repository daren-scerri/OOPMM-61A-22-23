using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessboard : MonoBehaviour
{
	public float padding;
	private GameObject[,] grid;
	void Start()
	{
		grid = new GameObject[12, 12];
		GameObject myprefab = Resources.Load("Square") as GameObject;
		for (int r = 0; r < 12; r++)
		{
			for (int c = 0; c < 12; c++)
			{
				grid[r, c] = Instantiate(myprefab, new Vector3(c + padding, r + padding), Quaternion.identity);

				if (r % 2 == 0)
				{
					if (c % 2 == 0)
					{
						grid[r, c].GetComponent<SpriteRenderer>().color = Color.black;
					}
				}
				else
				{
					if (c % 2 != 0)
					{
						grid[r, c].GetComponent<SpriteRenderer>().color = Color.black;
					}
				}
			}
		}
	}

	void Update()
	{
		if(Input.GetKeyDown("space"))
			SwitchColor();
	}

	bool white = false;
	void SwitchColor()
	{
		if (white)
		{
			CheckGrid(Color.white, Color.red);
			white = !white;
		}
		else
		{
			CheckGrid(Color.red, Color.white);
			white = !white;
		}
	}
	void CheckGrid(Color toCheck, Color toChange)
	{
		foreach (GameObject go in grid)
		{
			Color tempColor = go.GetComponent<SpriteRenderer>().color;
			if (tempColor == toCheck)
			{
				go.GetComponent<SpriteRenderer>().color = toChange;
			}

		}
	}

	//OLD VERSION BELOW, NEW VERSION ABOVE

	/*
	bool white = false;
	void SwitchColor()
	{
		Color toSwitch;
		if (white)
		{
			toSwitch = Color.red;
			white = !white;
		}
		else
		{
			toSwitch = Color.white;
			white = !white;
		}

		for (int r = 0; r < 12; r++)
		{
			for (int c = 0; c < 12; c++)
			{
				if (r % 2 == 0)
				{
					if (c % 2 != 0)
					{
						grid[r, c].GetComponent<SpriteRenderer>().color = toSwitch;
					}
				}
				else
				{
					if (c % 2 == 0)
					{
						grid[r, c].GetComponent<SpriteRenderer>().color = toSwitch;
					}
				}
			}
		}
	}*/
}