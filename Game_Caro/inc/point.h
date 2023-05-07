#ifndef POINT_H
#define POINT_H

#include <iostream>
using namespace std;

class Point {
 public:
    int x;
    int y;
 
    Point() {}
	Point(int x, int y);
	int getX();
	int getY();
	void setX(int x);
	void setY(int y);
    ~Point(){}
};

#endif
