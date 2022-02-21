#nullable disable

public class Ex12 {

    public void TicTacToe() {

        Console.WriteLine("Type the name of the players to start the game!");
        Console.WriteLine("Player X:");
        string player1 = Console.ReadLine();
        Console.WriteLine("Player O:");
        string player2 = Console.ReadLine();

        string[,] t = new string[3,3] { {"-", "-", "-"}, {"-", "-", "-"}, {"-","-","-"}};

        string gameTable = "  a   b   c \n"
                        +$"1  {t[0,0]} | {t[0,1]}  | {t[0,2]} \n"
                        +" ____|____|____ \n"
                        +$"2  {t[1,0]} | {t[1,1]}  | {t[1,2]} \n"
                        +" ____|____|____ \n"
                        +$"3  {t[2,0]} | {t[2,1]}  | {t[2,2]} \n"
                        +"     |    |   \n\n";

        bool validPlay = true;
        bool gameOver = false;
        string winner = "none";
        int numberOfPlays = 0;
        
        Console.WriteLine("The game begins!");
        Console.Write(gameTable);

        while(!gameOver && numberOfPlays < 9){
            
            //player X turn
            Console.WriteLine($"{player1}'s (X) turn. Type a position to mark! \n");
            string play1 = Console.ReadLine();
            (int r1, int c1) = GameEngine(play1);
            if(r1 != -1){
                if(t[r1, c1] != "-"){
                    validPlay = false;
                }
                else{
                    validPlay = true;
                };
            };
            while(r1 == -1 || !validPlay){
                Console.WriteLine("Type a valid position! (Ex: '1b') \n");
                play1 = Console.ReadLine();
                (r1, c1) = GameEngine(play1);

                if(r1 != -1){

                    if(t[r1, c1] != "-"){
                        validPlay = false;
                    }
                    else{
                        validPlay = true;
                    };
                };
            };

            t.SetValue("X", r1, c1);
            Console.Write("  a   b   c \n"
                        +$"1  {t[0,0]} | {t[0,1]}  | {t[0,2]} \n"
                        +" ____|____|____ \n"
                        +$"2  {t[1,0]} | {t[1,1]}  | {t[1,2]} \n"
                        +" ____|____|____ \n"
                        +$"3  {t[2,0]} | {t[2,1]}  | {t[2,2]} \n"
                        +"     |    |   \n\n");
            (gameOver, winner) = EndGameRule(t);
            numberOfPlays++;

            if(gameOver || numberOfPlays >= 9){
                break;
            }

            //player O turn
            Console.WriteLine($"{player2}'s (O) turn. Type a position to mark! \n");
            string play2 = Console.ReadLine();
            (int r2, int c2) = GameEngine(play2);
            if(r2 != -1){

                if(t[r2, c2] != "-"){
                    validPlay = false;
                }
                else{
                    validPlay = true;
                };
            };
            while(r2 == -1 || !validPlay){
                Console.WriteLine("Type a valid position! (Ex: '1b') \n");
                play2 = Console.ReadLine();
                (r2, c2) = GameEngine(play2);

                if(r2 != -1){

                    if(t[r2, c2] != "-"){
                        validPlay = false;
                    }
                    else{
                        validPlay = true;
                    };
                };
                    
            };

            t.SetValue("O", r2, c2);
            Console.Write("  a   b   c \n"
                        +$"1  {t[0,0]} | {t[0,1]}  | {t[0,2]} \n"
                        +" ____|____|____ \n"
                        +$"2  {t[1,0]} | {t[1,1]}  | {t[1,2]} \n"
                        +" ____|____|____ \n"
                        +$"3  {t[2,0]} | {t[2,1]}  | {t[2,2]} \n"
                        +"     |    |   \n\n");
            (gameOver, winner) = EndGameRule(t);

            numberOfPlays++;

        };

        if(winner == "X"){
            Console.WriteLine($"{player1} has won the game! Congratz!");
        }

        else if(winner == "O"){
            Console.WriteLine($"{player2} has won the game! Congratz!");
        }

        else {
            Console.WriteLine("The game ends in a DRAW!");
        }

        (int, int) GameEngine(string play){

            if(play == "1a"){
                return (0, 0);
            }
            else if(play == "1b"){
                return (0, 1);
            }
            else if(play == "1c"){
                return (0, 2);
            }
            else if(play == "2a"){
                return (1, 0);
            }
            else if(play == "2b"){
                return (1, 1);
            }
            else if(play == "2c"){
                return (1, 2);
            }
            else if(play == "3a"){
                return (2, 0);
            }
            else if(play == "3b"){
                return (2, 1);
            }
            else if(play == "3c"){
                return (2, 2);
            }
            else{
                return (-1, -1);
            }
        };

        (bool, string) EndGameRule(string[,] t){
            
            if(t[0, 0] == t[0, 1] && t[0, 1] == t[0, 2] && t[0, 0] != "-"){
                return (true, t[0, 0]);
            }

            else if(t[1, 0] == t[1, 1] && t[1, 1] == t[1, 2] && t[1, 0] != "-"){
                return (true, t[1, 0]);
            }

            else if(t[2, 0] == t[2, 1] && t[2, 1] == t[2, 2] && t[2, 0] != "-"){
                return (true, t[2, 0]);
            }

            else if(t[0, 0] == t[1, 0] && t[1, 0] == t[2, 0] && t[0, 0] != "-"){
                return (true, t[0, 0]);
            }

            else if(t[0, 1] == t[1, 1] && t[1, 1] == t[2, 1] && t[0, 1] != "-"){
                return (true, t[0, 1]);
            }

            else if(t[0, 2] == t[1, 2] && t[1, 2] == t[2, 2] && t[0, 2] != "-"){
                return (true, t[0, 2]);
            }

            else if(t[0, 0] == t[1, 1] && t[1, 1] == t[2, 2] && t[0, 0] != "-"){
                return (true, t[0, 0]);
            }

            else if(t[2, 0] == t[1, 1] && t[1, 1] == t[0, 2] && t[2, 0] != "-"){
                return (true, t[2, 0]);
            }
            else {
                return(false, "none");
            }
        };
    }
};