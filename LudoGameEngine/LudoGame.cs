using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LudoGameEngine
{
    public class LudoGame : ILudoGame
    {
        private List<Player> _players = new List<Player>();
        private GameState _gameState = GameState.NotStarted;
        private int currentPlayerId = 0;
        private IDiece _diece = null;

        public LudoGame(IDiece diece)
        {
            _diece = diece;
        }

        public Player AddPlayer(string name, PlayerColor color)
        {
            if (_gameState != GameState.NotStarted)
            {
                throw new Exception($"Unable to add player since game is {_gameState}");
            }

            if (_players.Where(p => p.PlayerColor == color).Count() > 0)
            {
                return null;
            }

            Player player = new Player()
            {
                PlayerId = _players.Count(),
                Name = name,
                PlayerColor = color
            };

            _players.Add(player);

            return player;
        }

        public void EndTurn(Player player)
        {
            // move to next player
            throw new NotImplementedException();
        }

        public Piece[] GetAllPieces()
        {
            throw new NotImplementedException();
        }

        public Player GetCurrentPlayer()
        {
            throw new NotImplementedException();
        }

        public GameState GetGameState()
        {
            return _gameState;
        }

        public Player[] GetPlayers()
        {
            return _players.ToArray();
        }

        public void MovePiece(Player player, Piece piece)
        {
            throw new NotImplementedException();
        }

        public int RollDiece()
        {
            if (_gameState != GameState.Started)
            {
                throw new Exception($"Unable roll diece since the game is not started, it's current state is: {_gameState}");
            }

            return _diece.RollDiece();
        }

        public bool StartGame()
        {
            if (_gameState != GameState.NotStarted)
            {
                throw new Exception($"Unable to start game since it has the state {_gameState} only NotStarted games can be started");
            }

            if (_players.Count < 2)
            {
                throw new Exception("Atleast two players is needed to start the game");
            }

            if (_players.Count > 4)
            {
                throw new Exception("A max of four players can be in the game");
            }

            _gameState = GameState.Started;
            return true;
        }

        public void StartTurn(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
