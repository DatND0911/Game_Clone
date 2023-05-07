#include "../inc/caroview.h"
#include <string>
#include <fstream>
#include <vector>

Player CaroView::enterPlayer(int playerFlag)
{
    string name;
    cout << "Enter name player " << playerFlag << ": ";
    fflush(stdin);
    getline(cin, name);
    return Player(name, playerFlag);
}

void CaroView::displayPlayer(vector<Player> listGamer)
{
    for (int i = 0; i << listGamer.size(); i++)
    {
        cout << listGamer[i].output() << endl;
    }
}

void CaroView::saveToFile(vector<Player> listGamer)
{
    ofstream outFile;
    outFile.open("Result.txt", ios::app);
    for (int i = 0; i < listGamer.size(); i++)
    {
        outFile << listGamer[i].output() << endl;
    }
    outFile.close();
}
