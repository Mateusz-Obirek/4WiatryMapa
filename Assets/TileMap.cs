using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour{
  TileType[] tileTypes;

  int[,] tiles;

  int mapSizeX = 10;
  int mapSizeY = 10;

  void Start() {

    tiles = new int[mapSizeX,mapSizeY];

    for (int x=0; x<mapSizeX; x++) {
      for (int y=0; y<mapSizeY; y++) {
          tiles[x,y] = 0;    }
  }



}
