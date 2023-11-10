#pragma once
#include<iostream>
#include<vector>
#include"MessageBox.h"

using namespace std;

class GraduationMessage
{
private:
	vector<MessageBox> GraduationBox;
public:
	GraduationMessage() {

	}
	~GraduationMessage() {}

	void AddBox(string university, string major);

	void DeleteBox(string university, string major);

	MessageBox GetBox(string university, string major);
};

