#pragma once
#include<iostream>
#include<ctime>

using namespace std;

class Message
{
private:
	string Content;
	time_t Date;
	string Owner;
	bool Permit;

public:
	Message(string content, time_t date, string owner, bool permit) {
		Content = content;
		date = time(nullptr);
		Date = date;
		Owner = owner;
		Permit = permit;
	}
};

