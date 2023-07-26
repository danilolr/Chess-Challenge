using ChessChallenge.API;
using System;

public class RandomBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] m = board.GetLegalMoves();
        Random rng = new Random();
        return m[rng.Next(m.Length)];
    }
}