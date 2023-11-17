#pragma once
#include<iostream>
#include<vector>
#include"MessageBox.h"
#include"MessageTheme.h"

using namespace std;

class GraduationMessage : public MessageTheme
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

