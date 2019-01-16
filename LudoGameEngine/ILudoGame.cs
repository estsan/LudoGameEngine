namespace LudoGameEngine
{
    public interface ILudoGame
    {
       bool StartGame();
        Player AddPlayer(string name, PlayerColor color);
        Player[] GetPlayers(); 
        GameState GetGameState(); 
       void StartTurn(Player player);
       
       int RollDiece();

       void MovePiece(Player player, Piece piece);
       void EndTurn(Player player);

       Player GetCurrentPlayer();
       Piece[] GetAllPieces();


    }
}