#include "../inc/player.h"
#include "string"

Player::Player(string name, int playerFlag)
{
    this->name = name;
    this->playerFlag = playerFlag;
}

void Player::setPlayerFlag(int playerFlag)
{
    this->playerFlag = playerFlag;
}

string Player::getNamePlayer()
{
    return name;
}

int Player::getPlayerFlag()
{
    return playerFlag;
}

char Player::getShapeXO()
{
    return shape;
}

void Player::setWinMatch()
{
    ++win;
}

int Player::getWinMatch()
{
    return win;
}

void Player::setLoseMatch()
{
    ++lose;
}

int Player::getLoseMatch()
{
    return lose;
}

void Player::setDrawMatch()
{
    ++draw;
}

int Player::getDrawMatch()
{
    return draw;
}

// save to file
string Player::output()
{
    string result;
    result = "Player name: " + name + "; Win match: " + to_string(win) + "; Lose match: " + to_string(lose) + "; Draw match: " + to_string(draw);
    return result;
}
