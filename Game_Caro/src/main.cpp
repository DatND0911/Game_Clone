#include "../inc/carocontroller.h"
#include <iostream>
#include <string>
#include <vector>
using namespace std;

int main()
{
    BoardState model;
    CaroView view;
    CaroController control;
    string name;
    int playerFlag;
    static int cnt = 0;
    vector<Player> listPlayer;
    Point point;

    cout << "___________CARO GAME___________\n";
    cout << "1. Play Game\n";
    cout << "2. Display Player\n";
    cout << "3. Quit Game\n";
    cout << "Enter choice: ";
    int choice;
    cin >> choice;

    switch (choice)
    {
    case 1:
        cin.ignore();
        cout << "\n________PLAYER 1 - [X] \t PLAYER 2 - [O]________\n";
        cout << "Name player1: "; fflush(stdin); getline(cin, name);
        playerFlag = 1;
        listPlayer.push_back(Player(name, playerFlag));
        cout << "Name player2: "; fflush(stdin); getline(cin, name);
        playerFlag = 2;
        listPlayer.push_back(Player(name, playerFlag));
        while (1)
        {   
            // Turn player 1
            do {
                cout << "Player 1 chose point: ";
                cin >> point.x >> point.y;
            } while (point.x > 9 || point.y > 9 || control.checkExit(point) == false);
            cnt++;
            control.playTurn(point, listPlayer[0].getPlayerFlag());
            control.printCaroBoard();
            if (control.checkEnd(point) == true) {
                cout << "-----Player 1 is winner-----" << endl;
                control.setWinPlayer(listPlayer, listPlayer[0].getNamePlayer());
                control.setLosePlayer(listPlayer, listPlayer[1].getNamePlayer());
                control.saveToFile(listPlayer);
                break;
            }

            // Turn player 2
            do {
                cout << "Player 2 chose point: ";
                cin >> point.x >> point.y;
            } while (point.x > 9 || point.y > 9 || control.checkExit(point) == false);
            cnt++;
            control.playTurn(point, listPlayer[1].getPlayerFlag());
            control.printCaroBoard();
            if (control.checkEnd(point) == true) {
                cout << "-----Player 2 is winner-----" << endl;
                control.setWinPlayer(listPlayer, listPlayer[1].getNamePlayer());
                control.setLosePlayer(listPlayer, listPlayer[0].getNamePlayer());
                control.saveToFile(listPlayer);
                break;
            }

            if(cnt == 100) {
                cout << "----------Draw----------" << endl;
                control.setDrawPlayer(listPlayer);
                control.saveToFile(listPlayer);
                break;
            }
        }
        break;

    case 2:
        control.displayPlayer(listPlayer);
        control.saveToFile(listPlayer);
        break;

    case 3:
        cout << "End Game!!!\n";
        return 0;
        
    default:
        break;
    }
}