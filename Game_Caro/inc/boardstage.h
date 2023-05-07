#ifndef BOARDSTAGE_H
#define BOARDSTAGE_H

#include "point.h"
#include "player.h"

using namespace std;
#define SIZE 10

class BoardState {
 private:
	char boardArr[10][10];

 public:
    BoardState();
    //reset bang trang
    void resetBoard();
	bool checkExit(Point point);
    // Lay trang thai cua quan co tai 1 toa do xac dinh
	int getPosition(int x, int y);
	// set trang thai cho 1 quan co xac dinh
	void setPosition(int x, int y, int player);
	// Check chien thang
	bool checkEnd(int row, int col);
    void printBoard();
    ~BoardState() {}
};

#endif