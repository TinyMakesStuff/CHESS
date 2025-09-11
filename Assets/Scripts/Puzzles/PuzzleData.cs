using UnityEngine;

public class puzzleData
{
    // Just fill out the lists with the ids of the pieces you want :D
    public ChessPieceID[] whitePieceIds = new ChessPieceID[16];
    public ChessPieceID[] blackPieceIds = new ChessPieceID[16];

    // Fill these lists with where you want those pieces to go. USE -1 IN INDEX 0 FOR NO PIECE
    public int[,] whitePieceLocations = new int[16, 2];
    public int[,] blackPieceLocations = new int[16, 2];

    // Put in a var for which map to use later when we decide how we want those to work

    public puzzleData(ChessPieceID[] wIDs, ChessPieceID[] bIDs, int[,] wLs, int[,] bLs)
    {
        whitePieceIds = wIDs;
        blackPieceIds = bIDs;
        whitePieceLocations = wLs;
        blackPieceLocations = bLs;
    }
}
