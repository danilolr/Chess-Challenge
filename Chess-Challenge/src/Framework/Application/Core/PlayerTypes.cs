using System.Collections.Generic;
using ChessChallenge.Example;

namespace ChessChallenge.Application;

public class PlayerTypes
{
 
    public static Dictionary < ChallengeController.PlayerType, System.Type > playerTypes = new Dictionary < ChallengeController.PlayerType, System.Type > ();
    private static List<ChallengeController.PlayerType> playerTypeList = new List<ChallengeController.PlayerType>(); 

    private static void InitTypes()
    {
        PlayerTypes.playerTypes.Add(ChallengeController.PlayerType.EvilBot, typeof(EvilBot));
        PlayerTypes.playerTypes.Add(ChallengeController.PlayerType.MyBot, typeof(MyBot));
        PlayerTypes.playerTypes.Add(ChallengeController.PlayerType.RandomBot, typeof(RandomBot));
    }
        
    static PlayerTypes()
    {
        PlayerTypes.InitTypes();
        foreach (var kv in PlayerTypes.playerTypes)
        {
            playerTypeList.Add(kv.Key);
        }
    }

    public static string GetDescription(ChallengeController.PlayerType player)
    {
        string s = player.ToString();
        return s;
    }

    public static ChallengeController.PlayerType GetNextType(ChallengeController.PlayerType player)
    {
        int p = playerTypeList.IndexOf(player);
        if (p == -1)
        {
            return playerTypeList[0];
        } 
        else if (p == playerTypeList.Count-1)
        {
            return ChallengeController.PlayerType.Human;
        }
        else
        {
            return playerTypeList[p+1];
        }
    }
}