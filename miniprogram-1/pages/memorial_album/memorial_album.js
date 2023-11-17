// pages/memorial_album/memorial_album.js
Page({
  data: {
    messages: []
  },

  onLoad: function() {
    var that = this;
    wx.request({
      url: '你的服务器地址/memorial_album/messages',
      method: 'GET',
      success: function(res) {
        that.setData({
          messages: res.data
        });
      },
      fail: function() {
        console.log('获取数据失败');
      }
    });
  },

  navigateToUpload: function() {
    wx.navigateTo({
      url: '../upload/upload'
    });
  }
  
});
