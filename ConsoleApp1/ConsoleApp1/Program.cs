using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo bàn cờ
            Board board = new Board();
            //vẽ bàn cờ
            board.DrawBoard();
            //vòng lặp chơi game
            bool isGameOver = false;
            while (isGameOver) {
                Console.WriteLine("chọn quân cờ bạn muốn di chuyển (ví dụ:a2):);
                    string selectedPiece = Console.ReadLine();
                Console.WriteLine("chọn vị trí mới cho quân cờ (ví dụ: a4): ");
                string newPosition = Console.ReadLine();
                isGameOver = board.MovePiêc(selectedPiêc, newPosition);
                //vẽ lại bàn cờ
                board.DrawBoard();
            }
        }
    }
    class Board
    {
        private Piece[,] pieces;

        public Board()
        {
            pieces = new Piece[8, 8];
            //khởi tạo quân cờ trên bàn cờ
            //quân màu trắng 
            pieces[0, 0] = new
                Rook(PieceColor.White);
            pieces[0, 1] = new
                Knight(PieceColor.White);
            pieces[0, 2] = new
                Bishop(PieceColor.White);
            pieces[0, 3] = new
                Queen(PieceColor.White);
            pieces[0, 4] = new
                King(PieceColor.White);
            pieces[0, 5] = new
                Bishop(PieceColor.White);
            pieces[0, 6] = new
                Knight(PieceColor.White);
            pieces[0, 7] = new
                Rook(PieceColor.White);

            for (int i = 0; i < 8; i++)
            {
                pieces[1, i] = new
                    Pawn(PieceColor.White);
            }

            //quân màu đen 
            for (int i = 0; i < 8; i++)
            {
                pieces[6, i] = new
                    Pawn(PieceColor.Black);
            }

            pieces[7, 0] = new
                Rook(PieceColor.Black);
            pieces[7, 1] = new
                Knight(PieceColor.Black);
            pieces[7, 2] = new
                Bishop(PieceColor.Black);
            pieces[7, 3] = new
                Queen(PieceColor.Black);
            pieces[7, 4] = new
                King(PieceColor.Black);
            pieces[7, 5] = new
                Bishop(PieceColor.Black);
            pieces[7, 6] = new
                Knight(PieceColor.Black);
            pieces[7, 7] = new
                Rook(PieceColor.Black);
        }

        public bool MovePiece(string selectedPiece, string newPosition)
        {
            int selectedRow = selectedPiece[1] - 1;
            int selectedCol = selectedPiece[0] - 'a';

            int newRow = newPosition[1] - '1';
            int newCol = newPosition[0] - 'a';

            piece piece = pieces[selectedRow, selectedCol];
            if (piece == null)
            {
                Console.WriteLine("không có quân cờ ở vị trí đã chọn!");
                return false;
            }
            if (!piece.IsValidMove(selectedRow, selectedCol, newRow, newCol, pieces))
            {
                Console.WriteLine("quân cờ đã chọn không thể di chuyển đến vị trí mới!");
                return false;
            }
            pieces[selectedRow, selectedCol] = piece;
            Console.WriteLine("di chuyển quân cờ thành công!");
            return false;
        }
        pieces[selectedRow, selectedCol] = null;
            pieces[newRow, newCol] = piece;
            Console.WriteLine("di chuyển quân cờ thành công!");
            return false;
            }
    public void DrawBoard()
    {
        Console.Clear();
        for (int row = 7; row >= 0; row--)
        { for ()}    
    }
              }
    }
}
