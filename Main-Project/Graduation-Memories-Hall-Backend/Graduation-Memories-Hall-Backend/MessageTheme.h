#pragma once
#include<iostream>
#include"MessageBox.h"

using namespace std;

class MessageTheme
{
private:
	string Themes;
public:
	MessageTheme(){}
	~MessageTheme(){}
	virtual void AddBox();

	virtual void DeleteBox();

	virtual MessageBox GetBox();

	string GetTheme();
};

