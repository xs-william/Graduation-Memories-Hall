#pragma once
#include<iostream>

using namespace std;


class Individual
{
private:
	string Name;
	string Password;
	string ID;

public:
	//构造函数
	Individual(string name, string password, string id) {
		Name = name;
		Password = password;
		ID = id;
	}
	//析构函数
	~Individual() {}

	virtual void Edit();

	virtual bool Login();

	virtual void Logout();

	virtual void Register();
};

