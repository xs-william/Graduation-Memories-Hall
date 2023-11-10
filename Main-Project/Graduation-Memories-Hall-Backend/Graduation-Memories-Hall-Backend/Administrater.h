#pragma once
#include "Individual.h"
class Administrater :
	public Individual
{
public:
	void Edit() override;

	bool Login() override;

	void Logout() override;

	void Register() override;
};

