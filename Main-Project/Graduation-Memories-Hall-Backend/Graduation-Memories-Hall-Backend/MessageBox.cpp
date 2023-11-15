#include "MessageBox.h"

void MessageBox::AddMessage(string content, string owner, bool permit) {
    // 获取当前时间
    time_t currentDate = time(nullptr);

    // 创建新的消息对象并加入 Messages 向量中
    Message newMessage(content, currentDate, owner, permit);
    Messages.push_back(newMessage);

    // 输出提示信息
    cout << "Message added successfully.\n";
}

void MessageBox::DeleteMessage(int index) {
    // 检查 index 的有效性
    if (index < 0 || index >= Messages.size()) {
        cout << "Invalid message index.\n";
        return;
    }

    // 从 Messages 向量中删除指定索引的消息
    Messages.erase(Messages.begin() + index);

    // 输出提示信息
    cout << "Message deleted successfully.\n";
}

Message MessageBox::GetMessage(int index) {
    // 检查 index 的有效性
    if (index < 0 || index >= Messages.size()) {
        cout << "Invalid message index.\n";
        // 返回一个空的消息对象，表示无效
        return Message("", 0, "", false);
    }

    // 返回指定索引的消息
    return Messages[index];
}

Coordinate MessageBox::GetPosition()
{
    return this->Position;
}

string MessageBox::GetUniversity()
{
    return this->University;
}

string MessageBox::GetMajor()
{
    return this->Major;
}
