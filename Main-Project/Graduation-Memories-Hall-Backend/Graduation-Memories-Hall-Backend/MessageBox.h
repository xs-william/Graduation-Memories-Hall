#pragma once
#include<iostream>
#include<vector>
#include"Message.h"


using namespace std;

struct Coordinate {
	double Latitude;
	double Longitude;
};

class MessageBox
{
private:
	Coordinate Position;
	string University;
	string Major;
	vector<Message> Messages;

public:
	MessageBox(Coordinate position, string university, string major) {
		Position = position;
		University = university;
		Major = major;
	}

	~MessageBox() {}

	void AddMessage(string,string,bool);
	void DeleteMessage(int);
	Coordinate GetPosition();
	string GetUniversity();
	string GetMajor();
	Message GetMessage(int);
};

