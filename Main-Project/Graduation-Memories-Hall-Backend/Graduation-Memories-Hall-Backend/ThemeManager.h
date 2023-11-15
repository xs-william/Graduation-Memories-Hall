#pragma once
#include <iostream>
#include "MessageTheme.h"
#include "MemoryMap.h"
#include "GraduationMessage.h"
class ThemeManager
{
private:
	vector<MessageTheme> Themes;
public:
	void AddTheme(string);
	void DeleteTheme(string);
	MessageTheme GetTheme(string);
};

