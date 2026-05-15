using UnityEngine;

using System.Collections.Generic;



public class GridManager : MonoBehaviour

{

    public GameObject enemyPrefab;

    public int gridSize = 12;

    public int enemyCount = 5;



    private List<Vector2> usedPositions = new List<Vector2>();



    void Start()

    {

        GenerateGrid();

        SpawnEnemies();

    }



    void GenerateGrid()

    {

        // This method represents logical grid creation

        Debug.Log("12x12 Grid Generated");

    }



    Vector2 GetRandomGridPosition()

    {

        int x = Random.Range(0, gridSize);

        int y = Random.Range(0, gridSize);



        return new Vector2(x, y);

    }



    bool IsPositionAvailable(Vector2 position)

    {

        return !usedPositions.Contains(position);

    }



    void SpawnEnemies()

    {

        int spawned = 0;



        while (spawned < enemyCount)

        {

            Vector2 randomPos = GetRandomGridPosition();



            if (IsPositionAvailable(randomPos))

            {

                Instantiate(enemyPrefab, randomPos, Quaternion.identity);

                usedPositions.Add(randomPos);

                spawned++;



                Debug.Log("Enemy Spawned at: " + randomPos);

            }

        }

    }

}