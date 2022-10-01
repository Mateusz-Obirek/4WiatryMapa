using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour{
  public TileType[] tileTypes;

  int[,] tiles;

  int mapSizeX = 10;
  int mapSizeY = 10;

  void Start() {

    tiles = new int[mapSizeX,mapSizeY];

    for (int x=0; x<mapSizeX; x++) {
      for (int y=0; y<mapSizeY; y++) {
          tiles[x,y] = 0;    }}

tiles[2,2] = 0;



  GenerateMapVisual();
}


void  GenerateMapVisual(){
  bool firstOffset = true;
  for (int x=0; x<mapSizeX; x++) {
    for (int z=0; z<mapSizeY; z++) {
      TileType tt = tileTypes[ tiles[x,z] ];
      float offsetX = firstOffset?0:0.3f;
      GameObject go = Instantiate ( tt.tileVisualPrefab, new Vector3(0.6f*z+offsetX,0,0.58f*x), Quaternion.Euler(90, 90, 0));

      go.name = $"Hex_{x}_{z}";
    }
    firstOffset=!firstOffset;
  }
}
}
