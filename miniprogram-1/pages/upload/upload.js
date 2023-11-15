// pages/upload/upload.js
Page({
  data: {
    userName: '',
    userMessage: '',
    imagePath: ''
  },

  onInputName: function(event) {
    this.setData({
      userName: event.detail.value
    });
  },

  onInputMessage: function(event) {
    this.setData({
      userMessage: event.detail.value
    });
  },

  doUpload: function() {
    var that = this;
    // 选择图片
    wx.chooseImage({
      success: function(res) {
        var tempFilePaths = res.tempFilePaths;
        that.setData({
          imagePath: tempFilePaths[0]
        });
      }
    });
  },

  submitMessage: function() {
    var that = this;
    // 上传图片到服务器
    wx.uploadFile({
      url: '你的服务器地址/upload_image',
      filePath: this.data.imagePath,
      name: 'file',
      success: function(res) {
        var data = JSON.parse(res.data);
        // 将其他信息和图片地址一起上传
        wx.request({
          url: '你的服务器地址/memorial_album/upload',
          method: 'POST',
          data: {
            user: that.data.userName,
            image: data.url, // 假设服务器返回文件的URL
            message: that.data.userMessage
          },
          success: function(res) {
            wx.showToast({
              title: '上传成功',
              icon: 'success',
              duration: 2000
            });
          }
        });
      }
    });
  }
});
