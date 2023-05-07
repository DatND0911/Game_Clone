#ifndef CAROVIEW_H
#define CAROVIEW_H

#include "player.h"
#include <vector>

class CaroView {
 private:
    vector<Player> listPlayer;

 public:
    CaroView() {}
    Player enterPlayer(int playerFlag);
    void displayPlayer(vector<Player> listGamer);
    void saveToFile(vector<Player> listGamer);
    ~CaroView() {}
};

#endif
