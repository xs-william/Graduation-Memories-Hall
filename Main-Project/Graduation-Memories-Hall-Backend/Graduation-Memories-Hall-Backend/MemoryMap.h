#pragma once
#include<iostream>
#include<vector>
#include"MessageBox.h"
#include"MessageTheme.h"

using namespace std;

class MemoryMap : public MessageTheme
{
private:
	vector<MessageBox> MapBoxes;
public:
	MemoryMap() {

	}
	~MemoryMap() {}

	void AddBox(Coordinate coordinate,string university,string major);

	void DeleteBox(Coordinate coordinate);

	MessageBox GetBox(Coordinate coordinate);
};

