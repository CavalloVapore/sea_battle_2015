using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour
{

    private List<Tiles> map = new List<Tiles>();
    private TileDatabase tdTileDatabase;
    public int player = 2;

    public GameObject Base;
    public GameObject Mine;
    public GameObject Trade;
    public GameObject Shipyard;



    // Use this for initialization
    void Start()
    {
        bool bIsland1 = false;
        bool bIsland2 = false;
        bool bIsland3 = false;
        bool bIsland4 = false;
        bool bIsland5 = false;
        bool bIsland6 = false;

        tdTileDatabase = GameObject.FindGameObjectWithTag("TileDatabase").GetComponent<TileDatabase>();
        for (int i = 0; i < 144; i++)
        {
            int random = Random.Range(2,5);
            map.Add(tdTileDatabase.tiles[random]);
        }
        if (player == 2)
        {
            map[7] = tdTileDatabase.tiles[10];
            map[7].bBuilding = true;
            map[7].iBuildingID = 1;
            map[15] = tdTileDatabase.tiles[7];
            map[15].bUnit = true;
            map[15].iShipID = 5;
            map[16] = tdTileDatabase.tiles[8];
            map[16].bBuilding = true;
            map[16].iBuildingID = 2;
            map[24] = tdTileDatabase.tiles[9];
            map[24].bBuilding = true;
            map[24].iBuildingID = 3;

            map[6] = tdTileDatabase.tiles[Random.Range(0,2)];
            map[14] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[23] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[32] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[33] = tdTileDatabase.tiles[Random.Range(0, 2)];


            map[136] = tdTileDatabase.tiles[10];
            map[136].bBuilding = true;
            map[136].iBuildingID = 1;
            map[128] = tdTileDatabase.tiles[7];
            map[128].bUnit = true;
            map[128].iShipID = 5;
            map[127] = tdTileDatabase.tiles[8];
            map[127].bBuilding = true;
            map[127].iBuildingID = 2;
            map[119] = tdTileDatabase.tiles[9];
            map[119].bBuilding = true;
            map[119].iBuildingID = 3;

            map[110] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[111] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[120] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[129] = tdTileDatabase.tiles[Random.Range(0, 2)];
            map[137] = tdTileDatabase.tiles[Random.Range(0, 2)];
        }
            /*
        else if (player == 4)
        {

        }*/
        while (!bIsland1)
        {
            int random = Random.Range(0, 34);
            if (map[random].ttTileType == (Tiles.TileType.Water) && map[random].iTileID > 1)
            {
                bIsland1 = true;
                map[random] = tdTileDatabase.tiles[Random.Range(5, 7)];
                if (random == 0)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 8 || random == 25)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 17)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random > 0 && random < 7)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 7)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 16 || random == 33)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 24)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
            }
        }

        while (!bIsland2)
        {
            int random = Random.Range(34, 76);
            if (map[random].ttTileType == (Tiles.TileType.Water) && map[random].iTileID > 1)
            {
                bIsland2 = true;
                map[random] = tdTileDatabase.tiles[Random.Range(5, 7)];
                if (random == 42||random == 59)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 34 || random == 51||random ==68)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 50 || random == 67)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 41 || random == 58||random ==75)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
            }
        }

        while (!bIsland3)
        {
            int random = Random.Range(34, 76);
            if (map[random].ttTileType == (Tiles.TileType.Water) && map[random].iTileID > 1)
            {
                bIsland3 = true;
                map[random] = tdTileDatabase.tiles[Random.Range(5, 7)];
                if (random == 42 || random == 59)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 34 || random == 51 || random == 68)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 50 || random == 67)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 41 || random == 58 || random == 75)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
            }
        }

        while (!bIsland4)
        {
            int random = Random.Range(76, 110);
            if (map[random].ttTileType == (Tiles.TileType.Water) && map[random].iTileID > 1)
            {
                bIsland4 = true;
                map[random] = tdTileDatabase.tiles[Random.Range(5, 7)];
                if (random == 76 || random == 93)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 85 || random == 102)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 84 || random == 101)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 92 || random == 109)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
            }
        }

        while (!bIsland5)
        {
            int random = Random.Range(76, 110);
            if (map[random].ttTileType == (Tiles.TileType.Water) && map[random].iTileID > 1)
            {
                bIsland5 = true;
                map[random] = tdTileDatabase.tiles[Random.Range(5, 7)];
                if (random == 76 || random == 93)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 85 || random == 102)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 84 || random == 101)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 92 || random == 109)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
            }
        }

        while (!bIsland6)
        {
            int random = Random.Range(110, 144);
            if (map[random].ttTileType == (Tiles.TileType.Water) && map[random].iTileID > 1)
            {
                bIsland6 = true;
                map[random] = tdTileDatabase.tiles[Random.Range(5, 7)];
                if (random == 136)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 127 || random == 110)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 119)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random > 136 && random < 143)
                {
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 143)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 118 || random == 135)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else if (random == 126)
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
                else
                {
                    map[random - 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 9] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random - 8] = tdTileDatabase.tiles[Random.Range(0, 2)];
                    map[random + 1] = tdTileDatabase.tiles[Random.Range(0, 2)];
                }
            }
        }


        transform.Rotate(new Vector3(-90, 0, 0));
        for (int i = 0; i < 17; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                for (int j=0; j < 8; j++)
                {
                    Instantiate(map[(int)(i*8.5f)+j].goTile, new Vector3(i * -0.75f, 0, j * 0.866f), transform.rotation);
                }
            }
            else
            {
                for (int j=0; j < 9; j++)
                {
                    Instantiate(map[(int)((i-1) * 8.5f) +8+ j].goTile, new Vector3((i * -0.75f), 0, (j * 0.866f) - 0.433f), transform.rotation);
                }
            }

        }

        transform.Rotate(new Vector3(90, 0, 0));
        for (int i = 0; i < 17; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (map[(int)(i * 8.5f) + j].bUnit)
                    {
                        switch (map[(int)(i * 8.5f) + j].iShipID)
                        {
                            case (5):
                                Instantiate(Base, new Vector3(i * -0.75f, 1, j * 0.866f), transform.rotation);
                                break;
                        }
                    }
                    if (map[(int)(i * 8.5f) + j].bBuilding)
                    {
                        switch (map[(int)(i * 8.5f) + j].iBuildingID)
                        {
                            case (1):
                                Instantiate(Trade, new Vector3(i * -0.75f, 1, j * 0.866f), transform.rotation);
                                break;
                            case (2):
                                Instantiate(Mine, new Vector3(i * -0.75f, 1, j * 0.866f), transform.rotation);
                                break;
                            case (3):
                                Instantiate(Shipyard, new Vector3(i * -0.75f, 1, j * 0.866f), transform.rotation);
                                break;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < 9; j++)
                {
                    if (map[(int)((i - 1) * 8.5f) + 8 + j].bUnit)
                    {
                        switch (map[(int)((i - 1) * 8.5f) + 8 + j].iShipID)
                        {
                            case (5):
                                Instantiate(Base, new Vector3((i * -0.75f), 1, (j * 0.866f) - 0.433f), transform.rotation);
                                break;
                        }
                    }
                    if (map[(int)((i - 1) * 8.5f) + 8 + j].bBuilding)
                    {
                        switch (map[(int)((i - 1) * 8.5f) + 8 + j].iBuildingID)
                        {
                            case (1):
                                Instantiate(Trade, new Vector3((i * -0.75f), 1, (j * 0.866f) - 0.433f), transform.rotation);
                                break;
                            case (2):
                                Instantiate(Mine, new Vector3((i * -0.75f), 1, (j * 0.866f) - 0.433f), transform.rotation);
                                break;
                            case (3):
                                Instantiate(Shipyard, new Vector3((i * -0.75f), 1, (j * 0.866f) - 0.433f), transform.rotation);
                                break;
                        }
                    }
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
