#include "../inc/boardstage.h"

BoardState::BoardState()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            boardArr[i][j] = ' ';
        }
    }
}

// reset bang trang
void BoardState::resetBoard()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            boardArr[i][j] = ' ';
        }
    }
}

bool BoardState::checkExit(Point point)
{
    if (boardArr[point.x][point.y] != ' ')
    {
        return false;
    }
    return true;
}

// Lay trang thai cua quan co tai 1 toa do xac dinh
int BoardState::getPosition(int x, int y)
{
    return boardArr[x][y];
}

// set trang thai cho 1 quan co xac dinh
void BoardState::setPosition(int x, int y, int player)
{
    char mark;
    player = (player % 2) ? 1 : 2;
    mark = (player == 1) ? 'X' : 'O';
    boardArr[x][y] = mark;
}

// Check chien thang
bool BoardState::checkEnd(int row, int col)
{
    int r = 0, c = 0;
    int i;
    int width = SIZE;
    int height = SIZE;

    // Check hang ngang
    bool checkendRow;
    while (c < width - 3)
    {
        checkendRow = true;
        for (i = 0; i < 4; i++)
        {
            if (boardArr[row][c + i] != boardArr[row][col])
                checkendRow = false;
        }
        if (checkendRow)
            return true;
        c++;
    }

    // Check  hang doc
    bool checkendCol;
    while (r < height - 3)
    {
        checkendCol = true;
        for (i = 0; i < 4; i++)
        {
            if (boardArr[r + i][col] != boardArr[row][col])
                checkendCol = false;
        }
        if (checkendCol)
            return true;
        r++;
    }

    // Check duong cheo xuong
    r = row;
    c = col;
    bool checkend;
    while (r > 0 && c > 0)
    {
        r--;
        c--;
    }
    while (r < height - 3 && c < width - 3)
    {
        checkend = true;
        for (i = 0; i < 4; i++)
        {
            if (boardArr[r + i][c + i] != boardArr[row][col])
                checkend = false;
        }
        if (checkend)
            return true;
        r++;
        c++;
    }

    // Check duong cheo len
    r = row;
    c = col;
    while (r < height - 1 && c > 0)
    {
        r++;
        c--;
    }
    while (r >= 3 && c < height - 3)
    {
        checkend = true;
        for (i = 0; i < 4; i++)
        {
            if (boardArr[r + i][c + i] != boardArr[row][col])
                checkend = false;
        }
        if (checkend)
            return true;
        r--;
        c++;
    }

    // check draw
    //  for (int i = 0; i < 10; i++) {
    //  	for (int j = 0; j < 10; j++) {
    //  		if (boardArr[i][j] != ' ')
    //  		cnt++;
    //  	}
    //  }
    //  if(cnt == 100) {
    //  	return true;
    //  }
    return false;
}

void BoardState::printBoard()
{
    cout << "------------------------------------------" << endl;
    for (int i = 0; i < 10; i++)
    {
        for (unsigned int j = 0; j < 10; j++)
        {
            cout << "| " << boardArr[i][j] << " ";
        }
        cout << "|" << endl;
        cout << "------------------------------------------" << endl;
    }
}
