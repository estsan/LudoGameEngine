namespace LudoGameEngine
{
    public interface Itest2
    {
       void StartGame(Player firstPlayer);
       void StartGame(Player firstPlayer, Player secondPlayer);
       void StartGame(Player firstPlayer, Player secondPlayer, Player thirdPlayer);

       void StartGame(Player firstPlayer, Player secondPlayer, Player thirdPlayer, Player fourthPlayer);
       GameState GetGameState(); 
       void StartTurn(Player player);
       Player AddPlayer(string name, PlayerColor color);
       int RollDiece();

       void MoveBrick(Player player, Piece brick);
       void EndTurn(Player player);

       Player GetCurrentPlayer();
        Piece[] GetAllBricks();


    }
}