using System.ComponentModel;
using UnityEngine;

public class puzzle1 : puzzle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // white queen
        whitePieceLocations[0, 0] = 7;
        whitePieceLocations[0, 1] = 0;

        // white king
        whitePieceLocations[1, 0] = 0;
        whitePieceLocations[1, 1] = 0;

        // white rook
        whitePieceLocations[2, 0] = 4;
        whitePieceLocations[2, 1] = 0;

        // black king
        blackPieceLocations[0, 0] = 0;
        blackPieceLocations[0, 1] = 7;

        // sets every other piece as nonexistent
        for (int i = 3; i < 16; i++)
        {
            whitePieceLocations[i, 0] = -1;
        }

        for (int i = 1; i < 16; i++)
        {
            blackPieceLocations[i, 0] = -1;
        }

        // sets puzzle description
        puzzleDesc = "Mate in two";

        // set move locations
        aiMoveFrom = new int[1, 2];
        aiMoveTo = new int[1, 2];

        // first move, move the black pawn up one
        aiMoveFrom[0, 0] = 0;
        aiMoveFrom[0, 1] = 7;

        aiMoveTo[0, 0] = 1;
        aiMoveTo[0, 1] = 7;

        aiMoves = 1;

        // sets the moves the player needs to make
        whiteMoveTo = new int[2, 2];
        movedPieces = new ChessPieceID[2];

        // must move rook to 2,6 
        whiteMoveTo[0, 0] = 4;
        whiteMoveTo[0, 1] = 6;

        movedPieces[0] = ChessPieceID.StandardRook;

        // must move queen to 7,6 
        whiteMoveTo[1, 0] = 7;
        whiteMoveTo[1, 1] = 7;

        movedPieces[1] = ChessPieceID.StandardQueen;

        // Sets the reward
        reward = "Nothing :P";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
