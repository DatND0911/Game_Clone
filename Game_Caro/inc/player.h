#ifndef PLAYER_H
#define PLAYER_H

#include <iostream>
using namespace std;

class Player {
 private:	
	string name;
	int win = 0;
	int lose = 0;
	int draw = 0;	
	int playerFlag; // danh dau thu tu nguoi choi
	char shape; // PLAYER 1 - [X] and PLAYER 2 - [O]

 public:
	Player() {}
    Player(string name, int playerFlag);
	void setPlayerFlag(int playerFlag);
	string getNamePlayer();
	int getPlayerFlag();
	char getShapeXO();
	void setWinMatch();
	int getWinMatch();
	void setLoseMatch();
	int getLoseMatch();
	void setDrawMatch();
	int getDrawMatch();
	//save to file
	string output();
	~Player() {}
};

#endif