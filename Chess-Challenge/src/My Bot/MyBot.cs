using ChessChallenge.API;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.RegularExpressions;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        if(IsInCheck())
        {
            //move so not in check
        }
        if(first move)
        {
            //move pawn in front of king one square forward
        }
        else if(second move)
        {
            //capture highest value peice, where queen is safe
        }
        else
        {
            //move queen to random square where safe
        }
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }
}