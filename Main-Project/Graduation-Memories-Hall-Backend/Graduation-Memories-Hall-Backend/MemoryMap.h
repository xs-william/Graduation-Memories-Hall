#pragma once
#include<iostream>
#include<vector>
#include"MessageBox.h"

using namespace std;

class MemoryMap
{
private:
	vector<MessageBox> MapBoxes;
public:
	MemoryMap() {

	}
	~MemoryMap() {}

	void AddBox(Coordinate coordinate);

	void DeleteBox(Coordinate coordinate);

	MessageBox GetBox(Coordinate coordinate);
};

