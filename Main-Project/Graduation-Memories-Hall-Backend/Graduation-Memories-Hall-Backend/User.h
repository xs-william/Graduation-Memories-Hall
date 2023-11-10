#pragma once
#include "Individual.h"
class User :
	public Individual
{
private:
	string School;

public:
	void Edit() override;

	bool Login() override;

	void Logout() override;

	void Register() override;
};

