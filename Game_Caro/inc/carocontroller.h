#ifndef CAROCONTROLLER_H
#define CAROCONTROLLER_H

#include "boardstage.h"
#include "caroview.h"
#include <vector>

class CaroController {
 private:
    BoardState boardCaro;
    CaroView viewCaro;
    Point point;

 public:
    CaroController() {}
    void displayPlayer(vector<Player> dsPlayer);
    void saveToFile(vector<Player> dsPlayer);
    bool checkExit(Point point);
    bool checkEnd(Point point);
    void playTurn(Point point, int playerFlag);
    void printCaroBoard();
    void setWinPlayer(vector<Player> &dsPlayer,string name);
    void setLosePlayer(vector<Player> &dsPlayer, string name);
    void setDrawPlayer(vector<Player> &dsPlayer);
    ~CaroController() {}
};

#endif
