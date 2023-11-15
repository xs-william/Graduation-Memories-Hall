#include "MemoryMap.h"

void MemoryMap::AddBox(Coordinate coordinate, string university, string major) {
	// 检查是否存在相同坐标的 MessageBox
    for (MessageBox& box : MapBoxes) {
        if (box.GetPosition().Latitude == coordinate.Latitude && box.GetPosition().Longitude == coordinate.Longitude) {
            cout << "A MessageBox already exists at this coordinate.\n";
            return;
        }
    }

    // 创建新的 MessageBox 对象并加入 MapBoxes 向量中
    MessageBox newMessageBox(coordinate, university, major);
    MapBoxes.push_back(newMessageBox);

    // 输出提示信息
    cout << "MessageBox added successfully.\n";
}

void MemoryMap::DeleteBox(Coordinate coordinate) {
    // 查找并删除相同坐标的 MessageBox
    auto it = std::remove_if(MapBoxes.begin(), MapBoxes.end(), [coordinate](MessageBox& box) {
        return box.GetPosition().Latitude == coordinate.Latitude && box.GetPosition().Longitude == coordinate.Longitude;
        });

    // 检查是否找到并删除了 MessageBox
    if (it != MapBoxes.end()) {
        MapBoxes.erase(it, MapBoxes.end());
        cout << "MessageBox deleted successfully.\n";
    }
    else {
        cout << "No MessageBox found at this coordinate.\n";
    }
}

MessageBox MemoryMap::GetBox(Coordinate coordinate) {
    // 查找相同坐标的 MessageBox
    auto it = std::find_if(MapBoxes.begin(), MapBoxes.end(), [coordinate](MessageBox& box) {
        return box.GetPosition().Latitude == coordinate.Latitude && box.GetPosition().Longitude == coordinate.Longitude;
        });

    // 检查是否找到了 MessageBox
    if (it != MapBoxes.end()) {
        return *it;
    }
    else {
        // 返回一个空的 MessageBox 对象，表示未找到
        cout << "No MessageBox found at this coordinate.\n";
        return MessageBox(Coordinate{ 0.0, 0.0 }, "", "");
    }
}
