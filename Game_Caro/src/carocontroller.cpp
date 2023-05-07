#include "../inc/carocontroller.h"
#include <vector>

void CaroController::displayPlayer(vector<Player> dsPlayer)
{
    viewCaro.displayPlayer(dsPlayer);
}

void CaroController::saveToFile(vector<Player> dsPlayer)
{
    viewCaro.saveToFile(dsPlayer);
}

bool CaroController::checkExit(Point point)
{
    return boardCaro.checkExit(point);
}

bool CaroController::checkEnd(Point point)
{
    return boardCaro.checkEnd(point.x, point.y);
}

void CaroController::playTurn(Point point, int playerFlag)
{
    boardCaro.setPosition(point.x, point.y, playerFlag);
}

void CaroController::printCaroBoard()
{
    boardCaro.printBoard();
}

void CaroController::setWinPlayer(vector<Player> &dsPlayer, string name)
{
    if (dsPlayer[0].getNamePlayer().compare(name) == 0)
    {
        dsPlayer[0].setWinMatch();
    }
    else
    {
        dsPlayer[1].setWinMatch();
    }
}

void CaroController::setLosePlayer(vector<Player> &dsPlayer, string name)
{
    if (dsPlayer[0].getNamePlayer().compare(name) == 0)
    {
        dsPlayer[0].setLoseMatch();
    }
    else
    {
        dsPlayer[1].setLoseMatch();
    }
}

void CaroController::setDrawPlayer(vector<Player> &dsPlayer)
{
    dsPlayer[0].setDrawMatch();
    dsPlayer[1].setDrawMatch();
}
