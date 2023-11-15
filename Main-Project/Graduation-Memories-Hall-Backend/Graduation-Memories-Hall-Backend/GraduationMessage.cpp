#include "GraduationMessage.h"

void GraduationMessage::AddBox(string university, string major) {
    // 检查是否存在相同大学和专业的 MessageBox
    for (MessageBox& box : GraduationBox) {
        if (box.GetUniversity() == university && box.GetMajor() == major) {
            cout << "A MessageBox for this university and major already exists.\n";
            return;
        }
    }

    // 创建新的 MessageBox 对象并加入 GraduationBox 向量中
    Coordinate position{ 0.0, 0.0 };  // 你可能需要提供坐标信息
    MessageBox newMessageBox(position, university, major);
    GraduationBox.push_back(newMessageBox);

    // 输出提示信息
    cout << "MessageBox added successfully.\n";
}

void GraduationMessage::DeleteBox(string university, string major) {
    // 查找并删除相同大学和专业的 MessageBox
    auto it = std::remove_if(GraduationBox.begin(), GraduationBox.end(), [university, major](MessageBox& box) {
        return box.GetUniversity() == university && box.GetMajor() == major;
        });

    // 检查是否找到并删除了 MessageBox
    if (it != GraduationBox.end()) {
        GraduationBox.erase(it, GraduationBox.end());
        cout << "MessageBox deleted successfully.\n";
    }
    else {
        cout << "No MessageBox found for this university and major.\n";
    }
}

MessageBox GraduationMessage::GetBox(string university, string major) {
    // 查找相同大学和专业的 MessageBox
    auto it = std::find_if(GraduationBox.begin(), GraduationBox.end(), [university, major](MessageBox& box) {
        return box.GetUniversity() == university && box.GetMajor() == major;
        });

    // 检查是否找到了 MessageBox
    if (it != GraduationBox.end()) {
        return *it;
    }
    else {
        // 返回一个空的 MessageBox 对象，表示未找到
        cout << "No MessageBox found for this university and major.\n";
        return MessageBox(Coordinate{ 0.0, 0.0 }, "", "");
    }
}
